using Qkmaxware.Numbers;

namespace Qkmaxware.Measurement {

public class Voltage : MetricMeasurement {
    public static readonly Unit DefaultUnitOfMeasure = new Unit("Volts", "V");
    public override Unit UnitsOfMeasure => DefaultUnitOfMeasure;
    
    private Voltage (Scientific value, MetricPrefix prefix) : base(value, prefix) {}

    #region operators
    public static Voltage operator* (Scientific l, Voltage r) {
        return new Voltage(l + r.ValueAs(MetricPrefix.None), MetricPrefix.None);
    }
    public static Voltage operator* (Voltage l, Scientific r) {
        return new Voltage(l.ValueAs(MetricPrefix.None) + r, MetricPrefix.None);
    }
    public static Voltage operator+ (Voltage l, Voltage r) {
        return new Voltage(l.ValueAs(MetricPrefix.None) + r.ValueAs(MetricPrefix.None), MetricPrefix.None);
    }
    public static Voltage operator- (Voltage l, Voltage r) {
        return new Voltage(l.ValueAs(MetricPrefix.None) - r.ValueAs(MetricPrefix.None), MetricPrefix.None);
    }
    #endregion

    #region metric constructors

    /// <summary>
    /// Create a mass measured in volts
    /// </summary>
    /// <param name="value">volts</param>
    /// <returns>Voltage</returns>
    public static Voltage Volts(Scientific value) {
        return new Voltage(value, MetricPrefix.None);
    }
    /// <summary>
    /// Total value of this mass in volts
    /// </summary>
    /// <returns>volts</returns>
    public Scientific TotalVolts() {
        return this.ValueAs(MetricPrefix.None);
    }

    /// <summary>
    /// Create a mass measured in Yottavolts
    /// </summary>
    /// <param name="value">Yottavolts</param>
    /// <returns>Voltage</returns>
    public static Voltage Yottavolts(Scientific value) {
        return new Voltage(value, MetricPrefix.Yotta);
    }
    /// <summary>
    /// Total value of this mass in Yottavolts
    /// </summary>
    /// <returns>Yottavolts</returns>
    public Scientific TotalYottavolts() {
        return this.ValueAs(MetricPrefix.Yotta);
    }

    /// <summary>
    /// Create a mass measured in Zettavolts
    /// </summary>
    /// <param name="value">Zettavolts</param>
    /// <returns>Voltage</returns>
    public static Voltage Zettavolts(Scientific value) {
        return new Voltage(value, MetricPrefix.Zetta);
    }
    /// <summary>
    /// Total value of this mass in Zettavolts
    /// </summary>
    /// <returns>Zettavolts</returns>
    public Scientific TotalZettavolts() {
        return this.ValueAs(MetricPrefix.Zetta);
    }

    /// <summary>
    /// Create a mass measured in Exavolts
    /// </summary>
    /// <param name="value">Exavolts</param>
    /// <returns>Voltage</returns>
    public static Voltage Exavolts(Scientific value) {
        return new Voltage(value, MetricPrefix.Exa);
    }
    /// <summary>
    /// Total value of this mass in Exavolts
    /// </summary>
    /// <returns>Exavolts</returns>
    public Scientific TotalExavolts() {
        return this.ValueAs(MetricPrefix.Exa);
    }

    /// <summary>
    /// Create a mass measured in Petavolts
    /// </summary>
    /// <param name="value">Petavolts</param>
    /// <returns>Voltage</returns>
    public static Voltage Petavolts(Scientific value) {
        return new Voltage(value, MetricPrefix.Peta);
    }
    /// <summary>
    /// Total value of this mass in Petavolts
    /// </summary>
    /// <returns>Petavolts</returns>
    public Scientific TotalPetavolts() {
        return this.ValueAs(MetricPrefix.Peta);
    }

    /// <summary>
    /// Create a mass measured in Teravolts
    /// </summary>
    /// <param name="value">Teravolts</param>
    /// <returns>Voltage</returns>
    public static Voltage Teravolts(Scientific value) {
        return new Voltage(value, MetricPrefix.Tera);
    }
    /// <summary>
    /// Total value of this mass in Teravolts
    /// </summary>
    /// <returns>Teravolts</returns>
    public Scientific TotalTeravolts() {
        return this.ValueAs(MetricPrefix.Tera);
    }

    /// <summary>
    /// Create a mass measured in Gigavolts
    /// </summary>
    /// <param name="value">Gigavolts</param>
    /// <returns>Voltage</returns>
    public static Voltage Gigavolts(Scientific value) {
        return new Voltage(value, MetricPrefix.Giga);
    }
    /// <summary>
    /// Total value of this mass in Gigavolts
    /// </summary>
    /// <returns>Gigavolts</returns>
    public Scientific TotalGigavolts() {
        return this.ValueAs(MetricPrefix.Giga);
    }

    /// <summary>
    /// Create a mass measured in Megavolts
    /// </summary>
    /// <param name="value">Megavolts</param>
    /// <returns>Voltage</returns>
    public static Voltage Megavolts(Scientific value) {
        return new Voltage(value, MetricPrefix.Mega);
    }
    /// <summary>
    /// Total value of this mass in Megavolts
    /// </summary>
    /// <returns>Megavolts</returns>
    public Scientific TotalMegavolts() {
        return this.ValueAs(MetricPrefix.Mega);
    }

    /// <summary>
    /// Create a mass measured in Kilovolts
    /// </summary>
    /// <param name="value">Kilovolts</param>
    /// <returns>Voltage</returns>
    public static Voltage Kilovolts(Scientific value) {
        return new Voltage(value, MetricPrefix.Kilo);
    }
    /// <summary>
    /// Total value of this mass in Kilovolts
    /// </summary>
    /// <returns>Kilovolts</returns>
    public Scientific TotalKilovolts() {
        return this.ValueAs(MetricPrefix.Kilo);
    }

    /// <summary>
    /// Create a mass measured in Hectovolts
    /// </summary>
    /// <param name="value">Hectovolts</param>
    /// <returns>Voltage</returns>
    public static Voltage Hectovolts(Scientific value) {
        return new Voltage(value, MetricPrefix.Hecto);
    }
    /// <summary>
    /// Total value of this mass in Hectovolts
    /// </summary>
    /// <returns>Hectovolts</returns>
    public Scientific TotalHectovolts() {
        return this.ValueAs(MetricPrefix.Hecto);
    }

    /// <summary>
    /// Create a mass measured in Decavolts
    /// </summary>
    /// <param name="value">Decavolts</param>
    /// <returns>Voltage</returns>
    public static Voltage Decavolts(Scientific value) {
        return new Voltage(value, MetricPrefix.Deca);
    }
    /// <summary>
    /// Total value of this mass in Decavolts
    /// </summary>
    /// <returns>Decavolts</returns>
    public Scientific TotalDecavolts() {
        return this.ValueAs(MetricPrefix.Deca);
    }

    /// <summary>
    /// Create a mass measured in Decivolts
    /// </summary>
    /// <param name="value">Decivolts</param>
    /// <returns>Voltage</returns>
    public static Voltage Decivolts(Scientific value) {
        return new Voltage(value, MetricPrefix.Deci);
    }
    /// <summary>
    /// Total value of this mass in Decivolts
    /// </summary>
    /// <returns>Decivolts</returns>
    public Scientific TotalDecivolts() {
        return this.ValueAs(MetricPrefix.Deci);
    }

    /// <summary>
    /// Create a mass measured in Centivolts
    /// </summary>
    /// <param name="value">Centivolts</param>
    /// <returns>Voltage</returns>
    public static Voltage Centivolts(Scientific value) {
        return new Voltage(value, MetricPrefix.Centi);
    }
    /// <summary>
    /// Total value of this mass in Centivolts
    /// </summary>
    /// <returns>Centivolts</returns>
    public Scientific TotalCentivolts() {
        return this.ValueAs(MetricPrefix.Centi);
    }

    /// <summary>
    /// Create a mass measured in Millivolts
    /// </summary>
    /// <param name="value">Millivolts</param>
    /// <returns>Voltage</returns>
    public static Voltage Millivolts(Scientific value) {
        return new Voltage(value, MetricPrefix.Milli);
    }
    /// <summary>
    /// Total value of this mass in Millivolts
    /// </summary>
    /// <returns>Millivolts</returns>
    public Scientific TotalMillivolts() {
        return this.ValueAs(MetricPrefix.Milli);
    }

    /// <summary>
    /// Create a mass measured in Microvolts
    /// </summary>
    /// <param name="value">Microvolts</param>
    /// <returns>Voltage</returns>
    public static Voltage Microvolts(Scientific value) {
        return new Voltage(value, MetricPrefix.Micro);
    }
    /// <summary>
    /// Total value of this mass in Microvolts
    /// </summary>
    /// <returns>Microvolts</returns>
    public Scientific TotalMicrovolts() {
        return this.ValueAs(MetricPrefix.Micro);
    }

    /// <summary>
    /// Create a mass measured in Nanovolts
    /// </summary>
    /// <param name="value">Nanovolts</param>
    /// <returns>Voltage</returns>
    public static Voltage Nanovolts(Scientific value) {
        return new Voltage(value, MetricPrefix.Nano);
    }
    /// <summary>
    /// Total value of this mass in Nanovolts
    /// </summary>
    /// <returns>Nanovolts</returns>
    public Scientific TotalNanovolts() {
        return this.ValueAs(MetricPrefix.Nano);
    }

    /// <summary>
    /// Create a mass measured in Picovolts
    /// </summary>
    /// <param name="value">Picovolts</param>
    /// <returns>Voltage</returns>
    public static Voltage Picovolts(Scientific value) {
        return new Voltage(value, MetricPrefix.Pico);
    }
    /// <summary>
    /// Total value of this mass in Picovolts
    /// </summary>
    /// <returns>Picovolts</returns>
    public Scientific TotalPicovolts() {
        return this.ValueAs(MetricPrefix.Pico);
    }

    /// <summary>
    /// Create a mass measured in Femtovolts
    /// </summary>
    /// <param name="value">Femtovolts</param>
    /// <returns>Voltage</returns>
    public static Voltage Femtovolts(Scientific value) {
        return new Voltage(value, MetricPrefix.Femto);
    }
    /// <summary>
    /// Total value of this mass in Femtovolts
    /// </summary>
    /// <returns>Femtovolts</returns>
    public Scientific TotalFemtovolts() {
        return this.ValueAs(MetricPrefix.Femto);
    }

    /// <summary>
    /// Create a mass measured in Attovolts
    /// </summary>
    /// <param name="value">Attovolts</param>
    /// <returns>Voltage</returns>
    public static Voltage Attovolts(Scientific value) {
        return new Voltage(value, MetricPrefix.Atto);
    }
    /// <summary>
    /// Total value of this mass in Attovolts
    /// </summary>
    /// <returns>Attovolts</returns>
    public Scientific TotalAttovolts() {
        return this.ValueAs(MetricPrefix.Atto);
    }

    /// <summary>
    /// Create a mass measured in Zeptovolts
    /// </summary>
    /// <param name="value">Zeptovolts</param>
    /// <returns>Voltage</returns>
    public static Voltage Zeptovolts(Scientific value) {
        return new Voltage(value, MetricPrefix.Zepto);
    }
    /// <summary>
    /// Total value of this mass in Zeptovolts
    /// </summary>
    /// <returns>Zeptovolts</returns>
    public Scientific TotalZeptovolts() {
        return this.ValueAs(MetricPrefix.Zepto);
    }


    /// <summary>
    /// Create a mass measured in Yoctovolts
    /// </summary>
    /// <param name="value">Yoctovolts</param>
    /// <returns>Voltage</returns>
    public static Voltage Yoctovolts(Scientific value) {
        return new Voltage(value, MetricPrefix.Yocto);
    }
    /// <summary>
    /// Total value of this mass in Yoctovolts
    /// </summary>
    /// <returns>Yoctovolts</returns>
    public Scientific TotalYoctovolts() {
        return this.ValueAs(MetricPrefix.Yocto);
    }

    #endregion
}

}