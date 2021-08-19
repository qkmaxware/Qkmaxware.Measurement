using Qkmaxware.Numbers;

namespace Qkmaxware.Measurement {

/// <summary>
/// Measurement of a rate of change in speed
/// </summary>
public class Acceleration : DerivedMeasure, INumeric<Acceleration>, IScalable<Scientific, Acceleration> {
    public static readonly Unit DefaultUnitOfMeasure = Speed.DefaultUnitOfMeasure/Duration.DefaultUnitOfMeasure;
    public override Unit UnitsOfMeasure => DefaultUnitOfMeasure;

    public Length Length {get; private set;}
    public Duration Time1 {get; private set;}
    public Duration Time2 {get; private set;}

    internal Acceleration (Length length, Duration time1, Duration time2) {
        this.Length = length;
        this.Time1 = time1;
        this.Time2 = time2;
    }

    public override string ToString() {
        return $"{TotalMetresPerSecondSquared()}{UnitsOfMeasure?.PrimarySymbol ?? string.Empty})";
    }

    #region operators 
    public Acceleration ScaleBy(Scientific value) => new Acceleration(this.Length.ScaleBy(value), this.Time1, this.Time2);
    public Acceleration Negate() {
        return new Acceleration(this.Length.Negate(), this.Time1, this.Time2);
    }

    public Acceleration Sqrt() {
        return new Acceleration(this.Length.Sqrt(), this.Time1.Sqrt(), this.Time2.Sqrt());
    }

    public Acceleration Add(Acceleration rhs) {
        // Convert to the same units
        var TL = this.Length.TotalMetres();
        var TR = this.Length.TotalMetres();

        var BL1 = this.Time1.TotalSeconds(); var BL2 = this.Time2.TotalSeconds();
        var BR1 = rhs.Time1.TotalSeconds(); var BR2 = rhs.Time2.TotalSeconds();

        // Convert to a common denominator
        var denominator1 = BL1 * BR1;
        var denominator2 = BL2 * BR2;
        var tl = TL * BR1 * BR2;
        var tr = TR * BL1 * BL2;

        return new Acceleration(
            Length.Metres(tl + tr),
            Duration.Seconds(denominator1),
            Duration.Seconds(denominator2)
        );
    }

    public Acceleration Subtract(Acceleration rhs) {
        // Convert to the same units
        var TL = this.Length.TotalMetres();
        var TR = this.Length.TotalMetres();

        var BL1 = this.Time1.TotalSeconds(); var BL2 = this.Time2.TotalSeconds();
        var BR1 = rhs.Time1.TotalSeconds(); var BR2 = rhs.Time2.TotalSeconds();

        // Convert to a common denominator
        var denominator1 = BL1 * BR1;
        var denominator2 = BL2 * BR2;
        var tl = TL * BR1 * BR2;
        var tr = TR * BL1 * BL2;

        return new Acceleration(
            Length.Metres(tl - tr),
            Duration.Seconds(denominator1),
            Duration.Seconds(denominator2)
        );
    }

    public Acceleration MultiplyBy(Acceleration rhs) {
        return new Acceleration(
            this.Length.MultiplyBy(rhs.Length),
            Duration.Seconds(this.Time1.TotalSeconds() * rhs.Time1.TotalSeconds()),
            Duration.Seconds(this.Time1.TotalSeconds() * rhs.Time2.TotalSeconds())
        );
    }

    public Acceleration DivideBy(Acceleration rhs) {
        return new Acceleration(
            Length.Metres(this.Length.TotalMetres() * rhs.Time1.TotalSeconds() * rhs.Time2.TotalSeconds()),
            this.Time1,
            Duration.Seconds(this.Time2.TotalSeconds() * this.Length.TotalMetres())
        );
    }
    #endregion

    #region metric
    public Acceleration MetresPerSecondSquared(Scientific value) {
        return new Acceleration(Length.Metres(value), Duration.Seconds(1), Duration.Seconds(1));
    }
    public Scientific TotalMetresPerSecondSquared() {
        return this.Length.TotalMetres() / (Time1.TotalSeconds() * Time2.TotalSeconds());
    }
    #endregion
}

}