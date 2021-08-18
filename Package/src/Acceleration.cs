using Qkmaxware.Numbers;

namespace Qkmaxware.Measurement {

/// <summary>
/// Measurement of a rate of change in speed
/// </summary>
public class Acceleration : DerivedMeasure {
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

    #region metric
    public Scientific TotalMetresPerSecondSquared() {
        return this.Length.TotalMetres() / (Time1.TotalSeconds() * Time2.TotalSeconds());
    }
    #endregion
}

}