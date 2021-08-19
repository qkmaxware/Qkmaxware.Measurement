using Qkmaxware.Numbers;

namespace Qkmaxware.Measurement {

public class Current : MetricMeasurement {
    public static readonly Unit DefaultUnitOfMeasure = new Unit("Amperes", "A");
    public override Unit UnitsOfMeasure => DefaultUnitOfMeasure;
    
    private Current (Scientific value, MetricPrefix prefix) : base(value, prefix) {}

    #region operators
    public static Current operator* (Scientific l, Current r) {
        return new Current(l + r.ValueAs(MetricPrefix.None), MetricPrefix.None);
    }
    public static Current operator* (Current l, Scientific r) {
        return new Current(l.ValueAs(MetricPrefix.None) + r, MetricPrefix.None);
    }
    public static Current operator+ (Current l, Current r) {
        return new Current(l.ValueAs(MetricPrefix.None) + r.ValueAs(MetricPrefix.None), MetricPrefix.None);
    }
    public static Current operator- (Current l, Current r) {
        return new Current(l.ValueAs(MetricPrefix.None) - r.ValueAs(MetricPrefix.None), MetricPrefix.None);
    }
    #endregion

    #region metric constructors

    /// <summary>
    /// Create a mass measured in amperes
    /// </summary>
    /// <param name="value">amperes</param>
    /// <returns>Current</returns>
    public static Current Amperes(Scientific value) {
        return new Current(value, MetricPrefix.None);
    }
    /// <summary>
    /// Total value of this mass in amperes
    /// </summary>
    /// <returns>amperes</returns>
    public Scientific TotalAmperes() {
        return this.ValueAs(MetricPrefix.None);
    }

    /// <summary>
    /// Create a mass measured in Yottaamperes
    /// </summary>
    /// <param name="value">Yottaamperes</param>
    /// <returns>Current</returns>
    public static Current Yottaamperes(Scientific value) {
        return new Current(value, MetricPrefix.Yotta);
    }
    /// <summary>
    /// Total value of this mass in Yottaamperes
    /// </summary>
    /// <returns>Yottaamperes</returns>
    public Scientific TotalYottaamperes() {
        return this.ValueAs(MetricPrefix.Yotta);
    }

    /// <summary>
    /// Create a mass measured in Zettaamperes
    /// </summary>
    /// <param name="value">Zettaamperes</param>
    /// <returns>Current</returns>
    public static Current Zettaamperes(Scientific value) {
        return new Current(value, MetricPrefix.Zetta);
    }
    /// <summary>
    /// Total value of this mass in Zettaamperes
    /// </summary>
    /// <returns>Zettaamperes</returns>
    public Scientific TotalZettaamperes() {
        return this.ValueAs(MetricPrefix.Zetta);
    }

    /// <summary>
    /// Create a mass measured in Exaamperes
    /// </summary>
    /// <param name="value">Exaamperes</param>
    /// <returns>Current</returns>
    public static Current Exaamperes(Scientific value) {
        return new Current(value, MetricPrefix.Exa);
    }
    /// <summary>
    /// Total value of this mass in Exaamperes
    /// </summary>
    /// <returns>Exaamperes</returns>
    public Scientific TotalExaamperes() {
        return this.ValueAs(MetricPrefix.Exa);
    }

    /// <summary>
    /// Create a mass measured in Petaamperes
    /// </summary>
    /// <param name="value">Petaamperes</param>
    /// <returns>Current</returns>
    public static Current Petaamperes(Scientific value) {
        return new Current(value, MetricPrefix.Peta);
    }
    /// <summary>
    /// Total value of this mass in Petaamperes
    /// </summary>
    /// <returns>Petaamperes</returns>
    public Scientific TotalPetaamperes() {
        return this.ValueAs(MetricPrefix.Peta);
    }

    /// <summary>
    /// Create a mass measured in Teraamperes
    /// </summary>
    /// <param name="value">Teraamperes</param>
    /// <returns>Current</returns>
    public static Current Teraamperes(Scientific value) {
        return new Current(value, MetricPrefix.Tera);
    }
    /// <summary>
    /// Total value of this mass in Teraamperes
    /// </summary>
    /// <returns>Teraamperes</returns>
    public Scientific TotalTeraamperes() {
        return this.ValueAs(MetricPrefix.Tera);
    }

    /// <summary>
    /// Create a mass measured in Gigaamperes
    /// </summary>
    /// <param name="value">Gigaamperes</param>
    /// <returns>Current</returns>
    public static Current Gigaamperes(Scientific value) {
        return new Current(value, MetricPrefix.Giga);
    }
    /// <summary>
    /// Total value of this mass in Gigaamperes
    /// </summary>
    /// <returns>Gigaamperes</returns>
    public Scientific TotalGigaamperes() {
        return this.ValueAs(MetricPrefix.Giga);
    }

    /// <summary>
    /// Create a mass measured in Megaamperes
    /// </summary>
    /// <param name="value">Megaamperes</param>
    /// <returns>Current</returns>
    public static Current Megaamperes(Scientific value) {
        return new Current(value, MetricPrefix.Mega);
    }
    /// <summary>
    /// Total value of this mass in Megaamperes
    /// </summary>
    /// <returns>Megaamperes</returns>
    public Scientific TotalMegaamperes() {
        return this.ValueAs(MetricPrefix.Mega);
    }

    /// <summary>
    /// Create a mass measured in Kiloamperes
    /// </summary>
    /// <param name="value">Kiloamperes</param>
    /// <returns>Current</returns>
    public static Current Kiloamperes(Scientific value) {
        return new Current(value, MetricPrefix.Kilo);
    }
    /// <summary>
    /// Total value of this mass in Kiloamperes
    /// </summary>
    /// <returns>Kiloamperes</returns>
    public Scientific TotalKiloamperes() {
        return this.ValueAs(MetricPrefix.Kilo);
    }

    /// <summary>
    /// Create a mass measured in Hectoamperes
    /// </summary>
    /// <param name="value">Hectoamperes</param>
    /// <returns>Current</returns>
    public static Current Hectoamperes(Scientific value) {
        return new Current(value, MetricPrefix.Hecto);
    }
    /// <summary>
    /// Total value of this mass in Hectoamperes
    /// </summary>
    /// <returns>Hectoamperes</returns>
    public Scientific TotalHectoamperes() {
        return this.ValueAs(MetricPrefix.Hecto);
    }

    /// <summary>
    /// Create a mass measured in Decaamperes
    /// </summary>
    /// <param name="value">Decaamperes</param>
    /// <returns>Current</returns>
    public static Current Decaamperes(Scientific value) {
        return new Current(value, MetricPrefix.Deca);
    }
    /// <summary>
    /// Total value of this mass in Decaamperes
    /// </summary>
    /// <returns>Decaamperes</returns>
    public Scientific TotalDecaamperes() {
        return this.ValueAs(MetricPrefix.Deca);
    }

    /// <summary>
    /// Create a mass measured in Deciamperes
    /// </summary>
    /// <param name="value">Deciamperes</param>
    /// <returns>Current</returns>
    public static Current Deciamperes(Scientific value) {
        return new Current(value, MetricPrefix.Deci);
    }
    /// <summary>
    /// Total value of this mass in Deciamperes
    /// </summary>
    /// <returns>Deciamperes</returns>
    public Scientific TotalDeciamperes() {
        return this.ValueAs(MetricPrefix.Deci);
    }

    /// <summary>
    /// Create a mass measured in Centiamperes
    /// </summary>
    /// <param name="value">Centiamperes</param>
    /// <returns>Current</returns>
    public static Current Centiamperes(Scientific value) {
        return new Current(value, MetricPrefix.Centi);
    }
    /// <summary>
    /// Total value of this mass in Centiamperes
    /// </summary>
    /// <returns>Centiamperes</returns>
    public Scientific TotalCentiamperes() {
        return this.ValueAs(MetricPrefix.Centi);
    }

    /// <summary>
    /// Create a mass measured in Milliamperes
    /// </summary>
    /// <param name="value">Milliamperes</param>
    /// <returns>Current</returns>
    public static Current Milliamperes(Scientific value) {
        return new Current(value, MetricPrefix.Milli);
    }
    /// <summary>
    /// Total value of this mass in Milliamperes
    /// </summary>
    /// <returns>Milliamperes</returns>
    public Scientific TotalMilliamperes() {
        return this.ValueAs(MetricPrefix.Milli);
    }

    /// <summary>
    /// Create a mass measured in Microamperes
    /// </summary>
    /// <param name="value">Microamperes</param>
    /// <returns>Current</returns>
    public static Current Microamperes(Scientific value) {
        return new Current(value, MetricPrefix.Micro);
    }
    /// <summary>
    /// Total value of this mass in Microamperes
    /// </summary>
    /// <returns>Microamperes</returns>
    public Scientific TotalMicroamperes() {
        return this.ValueAs(MetricPrefix.Micro);
    }

    /// <summary>
    /// Create a mass measured in Nanoamperes
    /// </summary>
    /// <param name="value">Nanoamperes</param>
    /// <returns>Current</returns>
    public static Current Nanoamperes(Scientific value) {
        return new Current(value, MetricPrefix.Nano);
    }
    /// <summary>
    /// Total value of this mass in Nanoamperes
    /// </summary>
    /// <returns>Nanoamperes</returns>
    public Scientific TotalNanoamperes() {
        return this.ValueAs(MetricPrefix.Nano);
    }

    /// <summary>
    /// Create a mass measured in Picoamperes
    /// </summary>
    /// <param name="value">Picoamperes</param>
    /// <returns>Current</returns>
    public static Current Picoamperes(Scientific value) {
        return new Current(value, MetricPrefix.Pico);
    }
    /// <summary>
    /// Total value of this mass in Picoamperes
    /// </summary>
    /// <returns>Picoamperes</returns>
    public Scientific TotalPicoamperes() {
        return this.ValueAs(MetricPrefix.Pico);
    }

    /// <summary>
    /// Create a mass measured in Femtoamperes
    /// </summary>
    /// <param name="value">Femtoamperes</param>
    /// <returns>Current</returns>
    public static Current Femtoamperes(Scientific value) {
        return new Current(value, MetricPrefix.Femto);
    }
    /// <summary>
    /// Total value of this mass in Femtoamperes
    /// </summary>
    /// <returns>Femtoamperes</returns>
    public Scientific TotalFemtoamperes() {
        return this.ValueAs(MetricPrefix.Femto);
    }

    /// <summary>
    /// Create a mass measured in Attoamperes
    /// </summary>
    /// <param name="value">Attoamperes</param>
    /// <returns>Current</returns>
    public static Current Attoamperes(Scientific value) {
        return new Current(value, MetricPrefix.Atto);
    }
    /// <summary>
    /// Total value of this mass in Attoamperes
    /// </summary>
    /// <returns>Attoamperes</returns>
    public Scientific TotalAttoamperes() {
        return this.ValueAs(MetricPrefix.Atto);
    }

    /// <summary>
    /// Create a mass measured in Zeptoamperes
    /// </summary>
    /// <param name="value">Zeptoamperes</param>
    /// <returns>Current</returns>
    public static Current Zeptoamperes(Scientific value) {
        return new Current(value, MetricPrefix.Zepto);
    }
    /// <summary>
    /// Total value of this mass in Zeptoamperes
    /// </summary>
    /// <returns>Zeptoamperes</returns>
    public Scientific TotalZeptoamperes() {
        return this.ValueAs(MetricPrefix.Zepto);
    }


    /// <summary>
    /// Create a mass measured in Yoctoamperes
    /// </summary>
    /// <param name="value">Yoctoamperes</param>
    /// <returns>Current</returns>
    public static Current Yoctoamperes(Scientific value) {
        return new Current(value, MetricPrefix.Yocto);
    }
    /// <summary>
    /// Total value of this mass in Yoctoamperes
    /// </summary>
    /// <returns>Yoctoamperes</returns>
    public Scientific TotalYoctoamperes() {
        return this.ValueAs(MetricPrefix.Yocto);
    }

    #endregion
}

}