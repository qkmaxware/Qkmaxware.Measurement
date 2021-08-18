using Qkmaxware.Numbers;

namespace Qkmaxware.Measurement {

/// <summary>
/// A measurement of length or distance
/// </summary>
public class Length : MetricMeasurement {
    public static readonly Unit DefaultUnitOfMeasure = new Unit("Metres", "m");
    public override Unit UnitsOfMeasure => DefaultUnitOfMeasure;

    private Length (Scientific value, MetricPrefix prefix) : base(value, prefix) {}

    #region operators
    public static Length operator* (Scientific l, Length r) {
        return new Length(l + r.valueAs(MetricPrefix.None), MetricPrefix.None);
    }
    public static Length operator* (Length l, Scientific r) {
        return new Length(l.valueAs(MetricPrefix.None) + r, MetricPrefix.None);
    }
    public static Length operator+ (Length l, Length r) {
        return new Length(l.valueAs(MetricPrefix.None) + r.valueAs(MetricPrefix.None), MetricPrefix.None);
    }
    public static Length operator- (Length l, Length r) {
        return new Length(l.valueAs(MetricPrefix.None) - r.valueAs(MetricPrefix.None), MetricPrefix.None);
    }
    #endregion

    #region metric constructors

    /// <summary>
    /// Create a length measured in metres
    /// </summary>
    /// <param name="value">metres</param>
    /// <returns>Length</returns>
    public static Length Metres(Scientific value) {
        return new Length(value, MetricPrefix.None);
    }
    /// <summary>
    /// Total value of this length in metres
    /// </summary>
    /// <returns>metres</returns>
    public Scientific TotalMetres() {
        return this.valueAs(MetricPrefix.None);
    }

    /// <summary>
    /// Create a length measured in Yottametres
    /// </summary>
    /// <param name="value">Yottametres</param>
    /// <returns>Length</returns>
    public static Length Yottametres(Scientific value) {
        return new Length(value, MetricPrefix.Yotta);
    }
    /// <summary>
    /// Total value of this length in Yottametres
    /// </summary>
    /// <returns>Yottametres</returns>
    public Scientific TotalYottametres() {
        return this.valueAs(MetricPrefix.Yotta);
    }

    /// <summary>
    /// Create a length measured in Zettametres
    /// </summary>
    /// <param name="value">Zettametres</param>
    /// <returns>Length</returns>
    public static Length Zettametres(Scientific value) {
        return new Length(value, MetricPrefix.Zetta);
    }
    /// <summary>
    /// Total value of this length in Zettametres
    /// </summary>
    /// <returns>Zettametres</returns>
    public Scientific TotalZettametres() {
        return this.valueAs(MetricPrefix.Zetta);
    }

    /// <summary>
    /// Create a length measured in Exametres
    /// </summary>
    /// <param name="value">Exametres</param>
    /// <returns>Length</returns>
    public static Length Exametres(Scientific value) {
        return new Length(value, MetricPrefix.Exa);
    }
    /// <summary>
    /// Total value of this length in Exametres
    /// </summary>
    /// <returns>Exametres</returns>
    public Scientific TotalExametres() {
        return this.valueAs(MetricPrefix.Exa);
    }

    /// <summary>
    /// Create a length measured in Petametres
    /// </summary>
    /// <param name="value">Petametres</param>
    /// <returns>Length</returns>
    public static Length Petametres(Scientific value) {
        return new Length(value, MetricPrefix.Peta);
    }
    /// <summary>
    /// Total value of this length in Petametres
    /// </summary>
    /// <returns>Petametres</returns>
    public Scientific TotalPetametres() {
        return this.valueAs(MetricPrefix.Peta);
    }

    /// <summary>
    /// Create a length measured in Terametres
    /// </summary>
    /// <param name="value">Terametres</param>
    /// <returns>Length</returns>
    public static Length Terametres(Scientific value) {
        return new Length(value, MetricPrefix.Tera);
    }
    /// <summary>
    /// Total value of this length in Terametres
    /// </summary>
    /// <returns>Terametres</returns>
    public Scientific TotalTerametres() {
        return this.valueAs(MetricPrefix.Tera);
    }

    /// <summary>
    /// Create a length measured in Gigametres
    /// </summary>
    /// <param name="value">Gigametres</param>
    /// <returns>Length</returns>
    public static Length Gigametres(Scientific value) {
        return new Length(value, MetricPrefix.Giga);
    }
    /// <summary>
    /// Total value of this length in Gigametres
    /// </summary>
    /// <returns>Gigametres</returns>
    public Scientific TotalGigametres() {
        return this.valueAs(MetricPrefix.Giga);
    }

    /// <summary>
    /// Create a length measured in Megametres
    /// </summary>
    /// <param name="value">Megametres</param>
    /// <returns>Length</returns>
    public static Length Megametres(Scientific value) {
        return new Length(value, MetricPrefix.Mega);
    }
    /// <summary>
    /// Total value of this length in Megametres
    /// </summary>
    /// <returns>Megametres</returns>
    public Scientific TotalMegametres() {
        return this.valueAs(MetricPrefix.Mega);
    }

    /// <summary>
    /// Create a length measured in Kilometres
    /// </summary>
    /// <param name="value">Kilometres</param>
    /// <returns>Length</returns>
    public static Length Kilometres(Scientific value) {
        return new Length(value, MetricPrefix.Kilo);
    }
    /// <summary>
    /// Total value of this length in Kilometres
    /// </summary>
    /// <returns>Kilometres</returns>
    public Scientific TotalKilometres() {
        return this.valueAs(MetricPrefix.Kilo);
    }

    /// <summary>
    /// Create a length measured in Hectometres
    /// </summary>
    /// <param name="value">Hectometres</param>
    /// <returns>Length</returns>
    public static Length Hectometres(Scientific value) {
        return new Length(value, MetricPrefix.Hecto);
    }
    /// <summary>
    /// Total value of this length in Hectometres
    /// </summary>
    /// <returns>Hectometres</returns>
    public Scientific TotalHectometres() {
        return this.valueAs(MetricPrefix.Hecto);
    }

    /// <summary>
    /// Create a length measured in Decametres
    /// </summary>
    /// <param name="value">Decametres</param>
    /// <returns>Length</returns>
    public static Length Decametres(Scientific value) {
        return new Length(value, MetricPrefix.Deca);
    }
    /// <summary>
    /// Total value of this length in Decametres
    /// </summary>
    /// <returns>Decametres</returns>
    public Scientific TotalDecametres() {
        return this.valueAs(MetricPrefix.Deca);
    }

    /// <summary>
    /// Create a length measured in Decimetres
    /// </summary>
    /// <param name="value">Decimetres</param>
    /// <returns>Length</returns>
    public static Length Decimetres(Scientific value) {
        return new Length(value, MetricPrefix.Deci);
    }
    /// <summary>
    /// Total value of this length in Decimetres
    /// </summary>
    /// <returns>Decimetres</returns>
    public Scientific TotalDecimetres() {
        return this.valueAs(MetricPrefix.Deci);
    }

    /// <summary>
    /// Create a length measured in Centimetres
    /// </summary>
    /// <param name="value">Centimetres</param>
    /// <returns>Length</returns>
    public static Length Centimetres(Scientific value) {
        return new Length(value, MetricPrefix.Centi);
    }
    /// <summary>
    /// Total value of this length in Centimetres
    /// </summary>
    /// <returns>Centimetres</returns>
    public Scientific TotalCentimetres() {
        return this.valueAs(MetricPrefix.Centi);
    }

    /// <summary>
    /// Create a length measured in Millimetres
    /// </summary>
    /// <param name="value">Millimetres</param>
    /// <returns>Length</returns>
    public static Length Millimetres(Scientific value) {
        return new Length(value, MetricPrefix.Milli);
    }
    /// <summary>
    /// Total value of this length in Millimetres
    /// </summary>
    /// <returns>Millimetres</returns>
    public Scientific TotalMillimetres() {
        return this.valueAs(MetricPrefix.Milli);
    }

    /// <summary>
    /// Create a length measured in Micrometres
    /// </summary>
    /// <param name="value">Micrometres</param>
    /// <returns>Length</returns>
    public static Length Micrometres(Scientific value) {
        return new Length(value, MetricPrefix.Micro);
    }
    /// <summary>
    /// Total value of this length in Micrometres
    /// </summary>
    /// <returns>Micrometres</returns>
    public Scientific TotalMicrometres() {
        return this.valueAs(MetricPrefix.Micro);
    }

    /// <summary>
    /// Create a length measured in Nanometres
    /// </summary>
    /// <param name="value">Nanometres</param>
    /// <returns>Length</returns>
    public static Length Nanometres(Scientific value) {
        return new Length(value, MetricPrefix.Nano);
    }
    /// <summary>
    /// Total value of this length in Nanometres
    /// </summary>
    /// <returns>Nanometres</returns>
    public Scientific TotalNanometres() {
        return this.valueAs(MetricPrefix.Nano);
    }

    /// <summary>
    /// Create a length measured in Picometres
    /// </summary>
    /// <param name="value">Picometres</param>
    /// <returns>Length</returns>
    public static Length Picometres(Scientific value) {
        return new Length(value, MetricPrefix.Pico);
    }
    /// <summary>
    /// Total value of this length in Picometres
    /// </summary>
    /// <returns>Picometres</returns>
    public Scientific TotalPicometres() {
        return this.valueAs(MetricPrefix.Pico);
    }

    /// <summary>
    /// Create a length measured in Femtometres
    /// </summary>
    /// <param name="value">Femtometres</param>
    /// <returns>Length</returns>
    public static Length Femtometres(Scientific value) {
        return new Length(value, MetricPrefix.Femto);
    }
    /// <summary>
    /// Total value of this length in Femtometres
    /// </summary>
    /// <returns>Femtometres</returns>
    public Scientific TotalFemtometres() {
        return this.valueAs(MetricPrefix.Femto);
    }

    /// <summary>
    /// Create a length measured in Attometres
    /// </summary>
    /// <param name="value">Attometres</param>
    /// <returns>Length</returns>
    public static Length Attometres(Scientific value) {
        return new Length(value, MetricPrefix.Atto);
    }
    /// <summary>
    /// Total value of this length in Attometres
    /// </summary>
    /// <returns>Attometres</returns>
    public Scientific TotalAttometres() {
        return this.valueAs(MetricPrefix.Atto);
    }

    /// <summary>
    /// Create a length measured in Zeptometres
    /// </summary>
    /// <param name="value">Zeptometres</param>
    /// <returns>Length</returns>
    public static Length Zeptometres(Scientific value) {
        return new Length(value, MetricPrefix.Zepto);
    }
    /// <summary>
    /// Total value of this length in Zeptometres
    /// </summary>
    /// <returns>Zeptometres</returns>
    public Scientific TotalZeptometres() {
        return this.valueAs(MetricPrefix.Zepto);
    }


    /// <summary>
    /// Create a length measured in Yoctometres
    /// </summary>
    /// <param name="value">Yoctometres</param>
    /// <returns>Length</returns>
    public static Length Yoctometres(Scientific value) {
        return new Length(value, MetricPrefix.Yocto);
    }
    /// <summary>
    /// Total value of this length in Yoctometres
    /// </summary>
    /// <returns>Yoctometres</returns>
    public Scientific TotalYoctometres() {
        return this.valueAs(MetricPrefix.Yocto);
    }

    #endregion

    #region derived quantities
    public static Speed operator / (Length length, Duration time) {
        return new Speed (length, time);
    }
    #endregion

}

}