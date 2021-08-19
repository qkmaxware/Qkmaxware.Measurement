using Qkmaxware.Numbers;

namespace Qkmaxware.Measurement {

/// <summary>
/// A measurement of a length of time
/// </summary>
public class Duration : MetricMeasurement, ISquareRootable<Duration> {
    public static readonly Unit DefaultUnitOfMeasure = new Unit("Seconds", "s");
    public override Unit UnitsOfMeasure => DefaultUnitOfMeasure;
    
    public static readonly Duration OneSecond = new Duration(1, MetricPrefix.None);
    public static readonly Duration Infinite = new Duration(double.PositiveInfinity, MetricPrefix.None);

    private Duration (Scientific value, MetricPrefix prefix) : base(value, prefix) {}

    #region operators
    public Duration Sqrt() {
        return new Duration(this.ValueAs(MetricPrefix.None).Sqrt(), MetricPrefix.None);
    }
    public static Duration operator* (Scientific l, Duration r) {
        return new Duration(l + r.ValueAs(MetricPrefix.None), MetricPrefix.None);
    }
    public static Duration operator* (Duration l, Scientific r) {
        return new Duration(l.ValueAs(MetricPrefix.None) + r, MetricPrefix.None);
    }
    public static Duration operator+ (Duration l, Duration r) {
        return new Duration(l.ValueAs(MetricPrefix.None) + r.ValueAs(MetricPrefix.None), MetricPrefix.None);
    }
    public static Duration operator- (Duration l, Duration r) {
        return new Duration(l.ValueAs(MetricPrefix.None) - r.ValueAs(MetricPrefix.None), MetricPrefix.None);
    }
    #endregion

    #region metric constructors

    /// <summary>
    /// Create a duration measured in seconds
    /// </summary>
    /// <param name="value">seconds</param>
    /// <returns>Duration</returns>
    public static Duration Seconds(Scientific value) {
        return new Duration(value, MetricPrefix.None);
    }
    /// <summary>
    /// Total value of this duration in seconds
    /// </summary>
    /// <returns>seconds</returns>
    public Scientific TotalSeconds() {
        return this.ValueAs(MetricPrefix.None);
    }

    /// <summary>
    /// Create a duration measured in Yottaseconds
    /// </summary>
    /// <param name="value">Yottaseconds</param>
    /// <returns>Duration</returns>
    public static Duration Yottaseconds(Scientific value) {
        return new Duration(value, MetricPrefix.Yotta);
    }
    /// <summary>
    /// Total value of this duration in Yottaseconds
    /// </summary>
    /// <returns>Yottaseconds</returns>
    public Scientific TotalYottaseconds() {
        return this.ValueAs(MetricPrefix.Yotta);
    }

    /// <summary>
    /// Create a duration measured in Zettaseconds
    /// </summary>
    /// <param name="value">Zettaseconds</param>
    /// <returns>Duration</returns>
    public static Duration Zettaseconds(Scientific value) {
        return new Duration(value, MetricPrefix.Zetta);
    }
    /// <summary>
    /// Total value of this duration in Zettaseconds
    /// </summary>
    /// <returns>Zettaseconds</returns>
    public Scientific TotalZettaseconds() {
        return this.ValueAs(MetricPrefix.Zetta);
    }

    /// <summary>
    /// Create a duration measured in Exaseconds
    /// </summary>
    /// <param name="value">Exaseconds</param>
    /// <returns>Duration</returns>
    public static Duration Exaseconds(Scientific value) {
        return new Duration(value, MetricPrefix.Exa);
    }
    /// <summary>
    /// Total value of this duration in Exaseconds
    /// </summary>
    /// <returns>Exaseconds</returns>
    public Scientific TotalExaseconds() {
        return this.ValueAs(MetricPrefix.Exa);
    }

    /// <summary>
    /// Create a duration measured in Petaseconds
    /// </summary>
    /// <param name="value">Petaseconds</param>
    /// <returns>Duration</returns>
    public static Duration Petaseconds(Scientific value) {
        return new Duration(value, MetricPrefix.Peta);
    }
    /// <summary>
    /// Total value of this duration in Petaseconds
    /// </summary>
    /// <returns>Petaseconds</returns>
    public Scientific TotalPetaseconds() {
        return this.ValueAs(MetricPrefix.Peta);
    }

    /// <summary>
    /// Create a duration measured in Teraseconds
    /// </summary>
    /// <param name="value">Teraseconds</param>
    /// <returns>Duration</returns>
    public static Duration Teraseconds(Scientific value) {
        return new Duration(value, MetricPrefix.Tera);
    }
    /// <summary>
    /// Total value of this duration in Teraseconds
    /// </summary>
    /// <returns>Teraseconds</returns>
    public Scientific TotalTeraseconds() {
        return this.ValueAs(MetricPrefix.Tera);
    }

    /// <summary>
    /// Create a duration measured in Gigaseconds
    /// </summary>
    /// <param name="value">Gigaseconds</param>
    /// <returns>Duration</returns>
    public static Duration Gigaseconds(Scientific value) {
        return new Duration(value, MetricPrefix.Giga);
    }
    /// <summary>
    /// Total value of this duration in Gigaseconds
    /// </summary>
    /// <returns>Gigaseconds</returns>
    public Scientific TotalGigaseconds() {
        return this.ValueAs(MetricPrefix.Giga);
    }

    /// <summary>
    /// Create a duration measured in Megaseconds
    /// </summary>
    /// <param name="value">Megaseconds</param>
    /// <returns>Duration</returns>
    public static Duration Megaseconds(Scientific value) {
        return new Duration(value, MetricPrefix.Mega);
    }
    /// <summary>
    /// Total value of this duration in Megaseconds
    /// </summary>
    /// <returns>Megaseconds</returns>
    public Scientific TotalMegaseconds() {
        return this.ValueAs(MetricPrefix.Mega);
    }

    /// <summary>
    /// Create a duration measured in Kiloseconds
    /// </summary>
    /// <param name="value">Kiloseconds</param>
    /// <returns>Duration</returns>
    public static Duration Kiloseconds(Scientific value) {
        return new Duration(value, MetricPrefix.Kilo);
    }
    /// <summary>
    /// Total value of this duration in Kiloseconds
    /// </summary>
    /// <returns>Kiloseconds</returns>
    public Scientific TotalKiloseconds() {
        return this.ValueAs(MetricPrefix.Kilo);
    }

    /// <summary>
    /// Create a duration measured in Hectoseconds
    /// </summary>
    /// <param name="value">Hectoseconds</param>
    /// <returns>Duration</returns>
    public static Duration Hectoseconds(Scientific value) {
        return new Duration(value, MetricPrefix.Hecto);
    }
    /// <summary>
    /// Total value of this duration in Hectoseconds
    /// </summary>
    /// <returns>Hectoseconds</returns>
    public Scientific TotalHectoseconds() {
        return this.ValueAs(MetricPrefix.Hecto);
    }

    /// <summary>
    /// Create a duration measured in Decaseconds
    /// </summary>
    /// <param name="value">Decaseconds</param>
    /// <returns>Duration</returns>
    public static Duration Decaseconds(Scientific value) {
        return new Duration(value, MetricPrefix.Deca);
    }
    /// <summary>
    /// Total value of this duration in Decaseconds
    /// </summary>
    /// <returns>Decaseconds</returns>
    public Scientific TotalDecaseconds() {
        return this.ValueAs(MetricPrefix.Deca);
    }

    /// <summary>
    /// Create a duration measured in Deciseconds
    /// </summary>
    /// <param name="value">Deciseconds</param>
    /// <returns>Duration</returns>
    public static Duration Deciseconds(Scientific value) {
        return new Duration(value, MetricPrefix.Deci);
    }
    /// <summary>
    /// Total value of this duration in Deciseconds
    /// </summary>
    /// <returns>Deciseconds</returns>
    public Scientific TotalDeciseconds() {
        return this.ValueAs(MetricPrefix.Deci);
    }

    /// <summary>
    /// Create a duration measured in Centiseconds
    /// </summary>
    /// <param name="value">Centiseconds</param>
    /// <returns>Duration</returns>
    public static Duration Centiseconds(Scientific value) {
        return new Duration(value, MetricPrefix.Centi);
    }
    /// <summary>
    /// Total value of this duration in Centiseconds
    /// </summary>
    /// <returns>Centiseconds</returns>
    public Scientific TotalCentiseconds() {
        return this.ValueAs(MetricPrefix.Centi);
    }

    /// <summary>
    /// Create a duration measured in Milliseconds
    /// </summary>
    /// <param name="value">Milliseconds</param>
    /// <returns>Duration</returns>
    public static Duration Milliseconds(Scientific value) {
        return new Duration(value, MetricPrefix.Milli);
    }
    /// <summary>
    /// Total value of this duration in Milliseconds
    /// </summary>
    /// <returns>Milliseconds</returns>
    public Scientific TotalMilliseconds() {
        return this.ValueAs(MetricPrefix.Milli);
    }

    /// <summary>
    /// Create a duration measured in Microseconds
    /// </summary>
    /// <param name="value">Microseconds</param>
    /// <returns>Duration</returns>
    public static Duration Microseconds(Scientific value) {
        return new Duration(value, MetricPrefix.Micro);
    }
    /// <summary>
    /// Total value of this duration in Microseconds
    /// </summary>
    /// <returns>Microseconds</returns>
    public Scientific TotalMicroseconds() {
        return this.ValueAs(MetricPrefix.Micro);
    }

    /// <summary>
    /// Create a duration measured in Nanoseconds
    /// </summary>
    /// <param name="value">Nanoseconds</param>
    /// <returns>Duration</returns>
    public static Duration Nanoseconds(Scientific value) {
        return new Duration(value, MetricPrefix.Nano);
    }
    /// <summary>
    /// Total value of this duration in Nanoseconds
    /// </summary>
    /// <returns>Nanoseconds</returns>
    public Scientific TotalNanoseconds() {
        return this.ValueAs(MetricPrefix.Nano);
    }

    /// <summary>
    /// Create a duration measured in Picoseconds
    /// </summary>
    /// <param name="value">Picoseconds</param>
    /// <returns>Duration</returns>
    public static Duration Picoseconds(Scientific value) {
        return new Duration(value, MetricPrefix.Pico);
    }
    /// <summary>
    /// Total value of this duration in Picoseconds
    /// </summary>
    /// <returns>Picoseconds</returns>
    public Scientific TotalPicoseconds() {
        return this.ValueAs(MetricPrefix.Pico);
    }

    /// <summary>
    /// Create a duration measured in Femtoseconds
    /// </summary>
    /// <param name="value">Femtoseconds</param>
    /// <returns>Duration</returns>
    public static Duration Femtoseconds(Scientific value) {
        return new Duration(value, MetricPrefix.Femto);
    }
    /// <summary>
    /// Total value of this duration in Femtoseconds
    /// </summary>
    /// <returns>Femtoseconds</returns>
    public Scientific TotalFemtoseconds() {
        return this.ValueAs(MetricPrefix.Femto);
    }

    /// <summary>
    /// Create a duration measured in Attoseconds
    /// </summary>
    /// <param name="value">Attoseconds</param>
    /// <returns>Duration</returns>
    public static Duration Attoseconds(Scientific value) {
        return new Duration(value, MetricPrefix.Atto);
    }
    /// <summary>
    /// Total value of this duration in Attoseconds
    /// </summary>
    /// <returns>Attoseconds</returns>
    public Scientific TotalAttoseconds() {
        return this.ValueAs(MetricPrefix.Atto);
    }

    /// <summary>
    /// Create a duration measured in Zeptoseconds
    /// </summary>
    /// <param name="value">Zeptoseconds</param>
    /// <returns>Duration</returns>
    public static Duration Zeptoseconds(Scientific value) {
        return new Duration(value, MetricPrefix.Zepto);
    }
    /// <summary>
    /// Total value of this duration in Zeptoseconds
    /// </summary>
    /// <returns>Zeptoseconds</returns>
    public Scientific TotalZeptoseconds() {
        return this.ValueAs(MetricPrefix.Zepto);
    }


    /// <summary>
    /// Create a duration measured in Yoctoseconds
    /// </summary>
    /// <param name="value">Yoctoseconds</param>
    /// <returns>Duration</returns>
    public static Duration Yoctoseconds(Scientific value) {
        return new Duration(value, MetricPrefix.Yocto);
    }
    /// <summary>
    /// Total value of this duration in Yoctoseconds
    /// </summary>
    /// <returns>Yoctoseconds</returns>
    public Scientific TotalYoctoseconds() {
        return this.ValueAs(MetricPrefix.Yocto);
    }

    #endregion

    #region other constructors
    /// <summary>
    /// Create a duration measured in minutes
    /// </summary>
    /// <param name="value">minutes</param>
    /// <returns>Duration</returns>
    public static Duration Minutes(Scientific value) {
        return new Duration(value * 60, MetricPrefix.None);
    }
    /// <summary>
    /// Total value of this duration in minutes
    /// </summary>
    /// <returns>minutes</returns>
    public Scientific TotalMinutes() {
        return this.ValueAs(MetricPrefix.None) / 60;
    }

    /// <summary>
    /// Create a duration measured in hours
    /// </summary>
    /// <param name="value">hours</param>
    /// <returns>Duration</returns>
    public static Duration Hours(Scientific value) {
        return new Duration(value * 3600, MetricPrefix.None);
    }
    /// <summary>
    /// Total value of this duration in hours
    /// </summary>
    /// <returns>hours</returns>
    public Scientific TotalHours() {
        return this.ValueAs(MetricPrefix.None) / 3600;
    }

    /// <summary>
    /// Create a duration measured in days
    /// </summary>
    /// <param name="value">days</param>
    /// <returns>Duration</returns>
    public static Duration Days(Scientific value) {
        return Duration.Hours(24 * value);
    }
    /// <summary>
    /// Total value of this duration in days
    /// </summary>
    /// <returns>days</returns>
    public Scientific TotalDays() {
        return this.TotalHours() / 24;
    }
    #endregion

}

}