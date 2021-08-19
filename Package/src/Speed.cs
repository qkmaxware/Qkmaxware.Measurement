using Qkmaxware.Numbers;

namespace Qkmaxware.Measurement {

/// <summary>
/// Measurement of a speed
/// </summary>
public class Speed : DerivedMeasure, INumeric<Speed> {
    public static readonly Unit DefaultUnitOfMeasure = Length.DefaultUnitOfMeasure/Duration.DefaultUnitOfMeasure;
    public override Unit UnitsOfMeasure => DefaultUnitOfMeasure;

    public Length Length {get; private set;}
    public Duration Time {get; private set;}

    internal Speed (Length length, Duration time) {
        this.Length = length;
        this.Time = time;
    }

    public override string ToString() {
        return $"{TotalMetresPerSecond()}{UnitsOfMeasure?.PrimarySymbol ?? string.Empty}";
    }

    #region operators
    public Speed Negate() {
        return new Speed(this.Length.Negate(), this.Time);
    }

    public Speed Sqrt() {
        return new Speed(this.Length.Sqrt(), this.Time.Sqrt());
    }

    public Speed Add(Speed rhs) {
        // Convert all to the same units
        var BL = this.Time.TotalSeconds();
        var BR = rhs.Time.TotalSeconds();

        var TL = this.Length.TotalMetres();
        var TR = rhs.Length.TotalMetres();

        // Create a common base
        var bottom = BL * BR;
        var topLeft = TL * BR;
        var topRight = TR * BL;

        return new Speed(Length.Metres(topLeft + topRight), Duration.Seconds(bottom));
    }

    public Speed Subtract(Speed rhs) {
        // Convert all to the same units
        var BL = this.Time.TotalSeconds();
        var BR = rhs.Time.TotalSeconds();

        var TL = this.Length.TotalMetres();
        var TR = rhs.Length.TotalMetres();

        // Create a common base
        var bottom = BL * BR;
        var topLeft = TL * BR;
        var topRight = TR * BL;

        return new Speed(Length.Metres(topLeft - topRight), Duration.Seconds(bottom));
    }

    public Speed MultiplyBy(Speed rhs) {
        return new Speed(
            this.Length.MultiplyBy(rhs.Length),
            Duration.Seconds(this.Time.TotalSeconds() * rhs.Time.TotalSeconds())
        );
    }

    public Speed DivideBy(Speed rhs) {
        return new Speed(
            Length.Metres(this.Length.TotalMetres() * rhs.Time.TotalSeconds()),
            Duration.Seconds(this.Time.TotalSeconds() * rhs.Length.TotalMetres())
        );
    }
    #endregion

    #region metric
    public Scientific TotalMetresPerSecond() {
        return this.Length.TotalMetres() / this.Time.TotalSeconds();
    }
    public Scientific TotalKilometresPerHour() {
        return this.Length.TotalKilometres() / this.Time.TotalHours();
    }
    #endregion

    #region derived quantities

    public static Acceleration operator / (Speed speed, Duration time) {
        return new Acceleration(speed.Length, speed.Time, time);
    }

    #endregion
}

}