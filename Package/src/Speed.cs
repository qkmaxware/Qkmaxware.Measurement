using Qkmaxware.Numbers;

namespace Qkmaxware.Measurement {

/// <summary>
/// Measurement of a speed
/// </summary>
public class Speed : DerivedMeasure {
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