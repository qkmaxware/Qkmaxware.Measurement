using Qkmaxware.Numbers;

namespace Qkmaxware.Measurement {

public class Resistance : MetricMeasurement {
    public static readonly Unit DefaultUnitOfMeasure = new Unit("Ohms", "A");
    public override Unit UnitsOfMeasure => DefaultUnitOfMeasure;

    public static readonly Resistance Zero = new Resistance(Scientific.Zero, MetricPrefix.None);

    private Resistance (Scientific value, MetricPrefix prefix) : base(value, prefix) {}

    #region operators
    public static Resistance operator* (Scientific l, Resistance r) {
        return new Resistance(l + r.ValueAs(MetricPrefix.None), MetricPrefix.None);
    }
    public static Resistance operator* (Resistance l, Scientific r) {
        return new Resistance(l.ValueAs(MetricPrefix.None) + r, MetricPrefix.None);
    }
    public static Resistance operator+ (Resistance l, Resistance r) {
        return new Resistance(l.ValueAs(MetricPrefix.None) + r.ValueAs(MetricPrefix.None), MetricPrefix.None);
    }
    public static Resistance operator- (Resistance l, Resistance r) {
        return new Resistance(l.ValueAs(MetricPrefix.None) - r.ValueAs(MetricPrefix.None), MetricPrefix.None);
    }
    #endregion

    #region metric constructors

    /// <summary>
    /// Create a mass measured in ohms
    /// </summary>
    /// <param name="value">ohms</param>
    /// <returns>Resistance</returns>
    public static Resistance Ohms(Scientific value) {
        return new Resistance(value, MetricPrefix.None);
    }
    /// <summary>
    /// Total value of this mass in ohms
    /// </summary>
    /// <returns>ohms</returns>
    public Scientific TotalOhms() {
        return this.ValueAs(MetricPrefix.None);
    }

    /// <summary>
    /// Create a mass measured in Yottaohms
    /// </summary>
    /// <param name="value">Yottaohms</param>
    /// <returns>Resistance</returns>
    public static Resistance Yottaohms(Scientific value) {
        return new Resistance(value, MetricPrefix.Yotta);
    }
    /// <summary>
    /// Total value of this mass in Yottaohms
    /// </summary>
    /// <returns>Yottaohms</returns>
    public Scientific TotalYottaohms() {
        return this.ValueAs(MetricPrefix.Yotta);
    }

    /// <summary>
    /// Create a mass measured in Zettaohms
    /// </summary>
    /// <param name="value">Zettaohms</param>
    /// <returns>Resistance</returns>
    public static Resistance Zettaohms(Scientific value) {
        return new Resistance(value, MetricPrefix.Zetta);
    }
    /// <summary>
    /// Total value of this mass in Zettaohms
    /// </summary>
    /// <returns>Zettaohms</returns>
    public Scientific TotalZettaohms() {
        return this.ValueAs(MetricPrefix.Zetta);
    }

    /// <summary>
    /// Create a mass measured in Exaohms
    /// </summary>
    /// <param name="value">Exaohms</param>
    /// <returns>Resistance</returns>
    public static Resistance Exaohms(Scientific value) {
        return new Resistance(value, MetricPrefix.Exa);
    }
    /// <summary>
    /// Total value of this mass in Exaohms
    /// </summary>
    /// <returns>Exaohms</returns>
    public Scientific TotalExaohms() {
        return this.ValueAs(MetricPrefix.Exa);
    }

    /// <summary>
    /// Create a mass measured in Petaohms
    /// </summary>
    /// <param name="value">Petaohms</param>
    /// <returns>Resistance</returns>
    public static Resistance Petaohms(Scientific value) {
        return new Resistance(value, MetricPrefix.Peta);
    }
    /// <summary>
    /// Total value of this mass in Petaohms
    /// </summary>
    /// <returns>Petaohms</returns>
    public Scientific TotalPetaohms() {
        return this.ValueAs(MetricPrefix.Peta);
    }

    /// <summary>
    /// Create a mass measured in Teraohms
    /// </summary>
    /// <param name="value">Teraohms</param>
    /// <returns>Resistance</returns>
    public static Resistance Teraohms(Scientific value) {
        return new Resistance(value, MetricPrefix.Tera);
    }
    /// <summary>
    /// Total value of this mass in Teraohms
    /// </summary>
    /// <returns>Teraohms</returns>
    public Scientific TotalTeraohms() {
        return this.ValueAs(MetricPrefix.Tera);
    }

    /// <summary>
    /// Create a mass measured in Gigaohms
    /// </summary>
    /// <param name="value">Gigaohms</param>
    /// <returns>Resistance</returns>
    public static Resistance Gigaohms(Scientific value) {
        return new Resistance(value, MetricPrefix.Giga);
    }
    /// <summary>
    /// Total value of this mass in Gigaohms
    /// </summary>
    /// <returns>Gigaohms</returns>
    public Scientific TotalGigaohms() {
        return this.ValueAs(MetricPrefix.Giga);
    }

    /// <summary>
    /// Create a mass measured in Megaohms
    /// </summary>
    /// <param name="value">Megaohms</param>
    /// <returns>Resistance</returns>
    public static Resistance Megaohms(Scientific value) {
        return new Resistance(value, MetricPrefix.Mega);
    }
    /// <summary>
    /// Total value of this mass in Megaohms
    /// </summary>
    /// <returns>Megaohms</returns>
    public Scientific TotalMegaohms() {
        return this.ValueAs(MetricPrefix.Mega);
    }

    /// <summary>
    /// Create a mass measured in Kiloohms
    /// </summary>
    /// <param name="value">Kiloohms</param>
    /// <returns>Resistance</returns>
    public static Resistance Kiloohms(Scientific value) {
        return new Resistance(value, MetricPrefix.Kilo);
    }
    /// <summary>
    /// Total value of this mass in Kiloohms
    /// </summary>
    /// <returns>Kiloohms</returns>
    public Scientific TotalKiloohms() {
        return this.ValueAs(MetricPrefix.Kilo);
    }

    /// <summary>
    /// Create a mass measured in Hectoohms
    /// </summary>
    /// <param name="value">Hectoohms</param>
    /// <returns>Resistance</returns>
    public static Resistance Hectoohms(Scientific value) {
        return new Resistance(value, MetricPrefix.Hecto);
    }
    /// <summary>
    /// Total value of this mass in Hectoohms
    /// </summary>
    /// <returns>Hectoohms</returns>
    public Scientific TotalHectoohms() {
        return this.ValueAs(MetricPrefix.Hecto);
    }

    /// <summary>
    /// Create a mass measured in Decaohms
    /// </summary>
    /// <param name="value">Decaohms</param>
    /// <returns>Resistance</returns>
    public static Resistance Decaohms(Scientific value) {
        return new Resistance(value, MetricPrefix.Deca);
    }
    /// <summary>
    /// Total value of this mass in Decaohms
    /// </summary>
    /// <returns>Decaohms</returns>
    public Scientific TotalDecaohms() {
        return this.ValueAs(MetricPrefix.Deca);
    }

    /// <summary>
    /// Create a mass measured in Deciohms
    /// </summary>
    /// <param name="value">Deciohms</param>
    /// <returns>Resistance</returns>
    public static Resistance Deciohms(Scientific value) {
        return new Resistance(value, MetricPrefix.Deci);
    }
    /// <summary>
    /// Total value of this mass in Deciohms
    /// </summary>
    /// <returns>Deciohms</returns>
    public Scientific TotalDeciohms() {
        return this.ValueAs(MetricPrefix.Deci);
    }

    /// <summary>
    /// Create a mass measured in Centiohms
    /// </summary>
    /// <param name="value">Centiohms</param>
    /// <returns>Resistance</returns>
    public static Resistance Centiohms(Scientific value) {
        return new Resistance(value, MetricPrefix.Centi);
    }
    /// <summary>
    /// Total value of this mass in Centiohms
    /// </summary>
    /// <returns>Centiohms</returns>
    public Scientific TotalCentiohms() {
        return this.ValueAs(MetricPrefix.Centi);
    }

    /// <summary>
    /// Create a mass measured in Milliohms
    /// </summary>
    /// <param name="value">Milliohms</param>
    /// <returns>Resistance</returns>
    public static Resistance Milliohms(Scientific value) {
        return new Resistance(value, MetricPrefix.Milli);
    }
    /// <summary>
    /// Total value of this mass in Milliohms
    /// </summary>
    /// <returns>Milliohms</returns>
    public Scientific TotalMilliohms() {
        return this.ValueAs(MetricPrefix.Milli);
    }

    /// <summary>
    /// Create a mass measured in Microohms
    /// </summary>
    /// <param name="value">Microohms</param>
    /// <returns>Resistance</returns>
    public static Resistance Microohms(Scientific value) {
        return new Resistance(value, MetricPrefix.Micro);
    }
    /// <summary>
    /// Total value of this mass in Microohms
    /// </summary>
    /// <returns>Microohms</returns>
    public Scientific TotalMicroohms() {
        return this.ValueAs(MetricPrefix.Micro);
    }

    /// <summary>
    /// Create a mass measured in Nanoohms
    /// </summary>
    /// <param name="value">Nanoohms</param>
    /// <returns>Resistance</returns>
    public static Resistance Nanoohms(Scientific value) {
        return new Resistance(value, MetricPrefix.Nano);
    }
    /// <summary>
    /// Total value of this mass in Nanoohms
    /// </summary>
    /// <returns>Nanoohms</returns>
    public Scientific TotalNanoohms() {
        return this.ValueAs(MetricPrefix.Nano);
    }

    /// <summary>
    /// Create a mass measured in Picoohms
    /// </summary>
    /// <param name="value">Picoohms</param>
    /// <returns>Resistance</returns>
    public static Resistance Picoohms(Scientific value) {
        return new Resistance(value, MetricPrefix.Pico);
    }
    /// <summary>
    /// Total value of this mass in Picoohms
    /// </summary>
    /// <returns>Picoohms</returns>
    public Scientific TotalPicoohms() {
        return this.ValueAs(MetricPrefix.Pico);
    }

    /// <summary>
    /// Create a mass measured in Femtoohms
    /// </summary>
    /// <param name="value">Femtoohms</param>
    /// <returns>Resistance</returns>
    public static Resistance Femtoohms(Scientific value) {
        return new Resistance(value, MetricPrefix.Femto);
    }
    /// <summary>
    /// Total value of this mass in Femtoohms
    /// </summary>
    /// <returns>Femtoohms</returns>
    public Scientific TotalFemtoohms() {
        return this.ValueAs(MetricPrefix.Femto);
    }

    /// <summary>
    /// Create a mass measured in Attoohms
    /// </summary>
    /// <param name="value">Attoohms</param>
    /// <returns>Resistance</returns>
    public static Resistance Attoohms(Scientific value) {
        return new Resistance(value, MetricPrefix.Atto);
    }
    /// <summary>
    /// Total value of this mass in Attoohms
    /// </summary>
    /// <returns>Attoohms</returns>
    public Scientific TotalAttoohms() {
        return this.ValueAs(MetricPrefix.Atto);
    }

    /// <summary>
    /// Create a mass measured in Zeptoohms
    /// </summary>
    /// <param name="value">Zeptoohms</param>
    /// <returns>Resistance</returns>
    public static Resistance Zeptoohms(Scientific value) {
        return new Resistance(value, MetricPrefix.Zepto);
    }
    /// <summary>
    /// Total value of this mass in Zeptoohms
    /// </summary>
    /// <returns>Zeptoohms</returns>
    public Scientific TotalZeptoohms() {
        return this.ValueAs(MetricPrefix.Zepto);
    }


    /// <summary>
    /// Create a mass measured in Yoctoohms
    /// </summary>
    /// <param name="value">Yoctoohms</param>
    /// <returns>Resistance</returns>
    public static Resistance Yoctoohms(Scientific value) {
        return new Resistance(value, MetricPrefix.Yocto);
    }
    /// <summary>
    /// Total value of this mass in Yoctoohms
    /// </summary>
    /// <returns>Yoctoohms</returns>
    public Scientific TotalYoctoohms() {
        return this.ValueAs(MetricPrefix.Yocto);
    }

    #endregion
}

}