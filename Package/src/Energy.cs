using Qkmaxware.Numbers;

namespace Qkmaxware.Measurement {

/// <summary>
/// A measurement of length or distance
/// </summary>
public class Energy : MetricMeasurement {
    public static readonly Unit DefaultUnitOfMeasure = new Unit("Joules", "J");
    public override Unit UnitsOfMeasure => DefaultUnitOfMeasure;

    public static readonly Energy Zero = new Energy(0, MetricPrefix.None);

    private Energy (Scientific value, MetricPrefix prefix) : base(value, prefix) {}

    #region operators
    /*public Energy ScaleBy(Scientific scalar) => new Energy(scalar * this.ValueAs(MetricPrefix.None), MetricPrefix.None);
    public Energy Negate() {
        return new Energy(-1 * this.ValueAs(MetricPrefix.None), MetricPrefix.None);
    }

    public Energy Sqrt() {
        return new Energy(this.ValueAs(MetricPrefix.None).Sqrt(), MetricPrefix.None);
    }

    public Energy Add(Energy rhs) {
        return this + rhs;
    }

    public Energy Subtract(Energy rhs) {
        return this - rhs;
    }

    public Energy MultiplyBy(Energy rhs) {
        return new Energy(this.ValueAs(MetricPrefix.None) * rhs.ValueAs(MetricPrefix.None), MetricPrefix.None);
    }

    public Energy DivideBy(Energy rhs) {
        return new Energy(this.ValueAs(MetricPrefix.None) / rhs.ValueAs(MetricPrefix.None), MetricPrefix.None);
    }*/
    
    public static Energy operator* (Scientific l, Energy r) {
        return new Energy(l * r.ValueAs(MetricPrefix.None), MetricPrefix.None);
    }
    public static Energy operator* (Energy l, Scientific r) {
        return new Energy(l.ValueAs(MetricPrefix.None) * r, MetricPrefix.None);
    }
    public static Energy operator+ (Energy l, Energy r) {
        return new Energy(l.ValueAs(MetricPrefix.None) + r.ValueAs(MetricPrefix.None), MetricPrefix.None);
    }
    public static Energy operator- (Energy l, Energy r) {
        return new Energy(l.ValueAs(MetricPrefix.None) - r.ValueAs(MetricPrefix.None), MetricPrefix.None);
    }
    #endregion

    #region metric constructors

    /// <summary>
    /// Create a length measured in joules
    /// </summary>
    /// <param name="value">joules</param>
    /// <returns>Energy</returns>
    public static Energy Joules(Scientific value) {
        return new Energy(value, MetricPrefix.None);
    }
    /// <summary>
    /// Total value of this length in joules
    /// </summary>
    /// <returns>joules</returns>
    public Scientific TotalJoules() {
        return this.ValueAs(MetricPrefix.None);
    }

    /// <summary>
    /// Create a length measured in Yottajoules
    /// </summary>
    /// <param name="value">Yottajoules</param>
    /// <returns>Energy</returns>
    public static Energy Yottajoules(Scientific value) {
        return new Energy(value, MetricPrefix.Yotta);
    }
    /// <summary>
    /// Total value of this length in Yottajoules
    /// </summary>
    /// <returns>Yottajoules</returns>
    public Scientific TotalYottajoules() {
        return this.ValueAs(MetricPrefix.Yotta);
    }

    /// <summary>
    /// Create a length measured in Zettajoules
    /// </summary>
    /// <param name="value">Zettajoules</param>
    /// <returns>Energy</returns>
    public static Energy Zettajoules(Scientific value) {
        return new Energy(value, MetricPrefix.Zetta);
    }
    /// <summary>
    /// Total value of this length in Zettajoules
    /// </summary>
    /// <returns>Zettajoules</returns>
    public Scientific TotalZettajoules() {
        return this.ValueAs(MetricPrefix.Zetta);
    }

    /// <summary>
    /// Create a length measured in Exajoules
    /// </summary>
    /// <param name="value">Exajoules</param>
    /// <returns>Energy</returns>
    public static Energy Exajoules(Scientific value) {
        return new Energy(value, MetricPrefix.Exa);
    }
    /// <summary>
    /// Total value of this length in Exajoules
    /// </summary>
    /// <returns>Exajoules</returns>
    public Scientific TotalExajoules() {
        return this.ValueAs(MetricPrefix.Exa);
    }

    /// <summary>
    /// Create a length measured in Petajoules
    /// </summary>
    /// <param name="value">Petajoules</param>
    /// <returns>Energy</returns>
    public static Energy Petajoules(Scientific value) {
        return new Energy(value, MetricPrefix.Peta);
    }
    /// <summary>
    /// Total value of this length in Petajoules
    /// </summary>
    /// <returns>Petajoules</returns>
    public Scientific TotalPetajoules() {
        return this.ValueAs(MetricPrefix.Peta);
    }

    /// <summary>
    /// Create a length measured in Terajoules
    /// </summary>
    /// <param name="value">Terajoules</param>
    /// <returns>Energy</returns>
    public static Energy Terajoules(Scientific value) {
        return new Energy(value, MetricPrefix.Tera);
    }
    /// <summary>
    /// Total value of this length in Terajoules
    /// </summary>
    /// <returns>Terajoules</returns>
    public Scientific TotalTerajoules() {
        return this.ValueAs(MetricPrefix.Tera);
    }

    /// <summary>
    /// Create a length measured in Gigajoules
    /// </summary>
    /// <param name="value">Gigajoules</param>
    /// <returns>Energy</returns>
    public static Energy Gigajoules(Scientific value) {
        return new Energy(value, MetricPrefix.Giga);
    }
    /// <summary>
    /// Total value of this length in Gigajoules
    /// </summary>
    /// <returns>Gigajoules</returns>
    public Scientific TotalGigajoules() {
        return this.ValueAs(MetricPrefix.Giga);
    }

    /// <summary>
    /// Create a length measured in Megajoules
    /// </summary>
    /// <param name="value">Megajoules</param>
    /// <returns>Energy</returns>
    public static Energy Megajoules(Scientific value) {
        return new Energy(value, MetricPrefix.Mega);
    }
    /// <summary>
    /// Total value of this length in Megajoules
    /// </summary>
    /// <returns>Megajoules</returns>
    public Scientific TotalMegajoules() {
        return this.ValueAs(MetricPrefix.Mega);
    }

    /// <summary>
    /// Create a length measured in Kilojoules
    /// </summary>
    /// <param name="value">Kilojoules</param>
    /// <returns>Energy</returns>
    public static Energy Kilojoules(Scientific value) {
        return new Energy(value, MetricPrefix.Kilo);
    }
    /// <summary>
    /// Total value of this length in Kilojoules
    /// </summary>
    /// <returns>Kilojoules</returns>
    public Scientific TotalKilojoules() {
        return this.ValueAs(MetricPrefix.Kilo);
    }

    /// <summary>
    /// Create a length measured in Hectojoules
    /// </summary>
    /// <param name="value">Hectojoules</param>
    /// <returns>Energy</returns>
    public static Energy Hectojoules(Scientific value) {
        return new Energy(value, MetricPrefix.Hecto);
    }
    /// <summary>
    /// Total value of this length in Hectojoules
    /// </summary>
    /// <returns>Hectojoules</returns>
    public Scientific TotalHectojoules() {
        return this.ValueAs(MetricPrefix.Hecto);
    }

    /// <summary>
    /// Create a length measured in Decajoules
    /// </summary>
    /// <param name="value">Decajoules</param>
    /// <returns>Energy</returns>
    public static Energy Decajoules(Scientific value) {
        return new Energy(value, MetricPrefix.Deca);
    }
    /// <summary>
    /// Total value of this length in Decajoules
    /// </summary>
    /// <returns>Decajoules</returns>
    public Scientific TotalDecajoules() {
        return this.ValueAs(MetricPrefix.Deca);
    }

    /// <summary>
    /// Create a length measured in Decijoules
    /// </summary>
    /// <param name="value">Decijoules</param>
    /// <returns>Energy</returns>
    public static Energy Decijoules(Scientific value) {
        return new Energy(value, MetricPrefix.Deci);
    }
    /// <summary>
    /// Total value of this length in Decijoules
    /// </summary>
    /// <returns>Decijoules</returns>
    public Scientific TotalDecijoules() {
        return this.ValueAs(MetricPrefix.Deci);
    }

    /// <summary>
    /// Create a length measured in Centijoules
    /// </summary>
    /// <param name="value">Centijoules</param>
    /// <returns>Energy</returns>
    public static Energy Centijoules(Scientific value) {
        return new Energy(value, MetricPrefix.Centi);
    }
    /// <summary>
    /// Total value of this length in Centijoules
    /// </summary>
    /// <returns>Centijoules</returns>
    public Scientific TotalCentijoules() {
        return this.ValueAs(MetricPrefix.Centi);
    }

    /// <summary>
    /// Create a length measured in Millijoules
    /// </summary>
    /// <param name="value">Millijoules</param>
    /// <returns>Energy</returns>
    public static Energy Millijoules(Scientific value) {
        return new Energy(value, MetricPrefix.Milli);
    }
    /// <summary>
    /// Total value of this length in Millijoules
    /// </summary>
    /// <returns>Millijoules</returns>
    public Scientific TotalMillijoules() {
        return this.ValueAs(MetricPrefix.Milli);
    }

    /// <summary>
    /// Create a length measured in Microjoules
    /// </summary>
    /// <param name="value">Microjoules</param>
    /// <returns>Energy</returns>
    public static Energy Microjoules(Scientific value) {
        return new Energy(value, MetricPrefix.Micro);
    }
    /// <summary>
    /// Total value of this length in Microjoules
    /// </summary>
    /// <returns>Microjoules</returns>
    public Scientific TotalMicrojoules() {
        return this.ValueAs(MetricPrefix.Micro);
    }

    /// <summary>
    /// Create a length measured in Nanojoules
    /// </summary>
    /// <param name="value">Nanojoules</param>
    /// <returns>Energy</returns>
    public static Energy Nanojoules(Scientific value) {
        return new Energy(value, MetricPrefix.Nano);
    }
    /// <summary>
    /// Total value of this length in Nanojoules
    /// </summary>
    /// <returns>Nanojoules</returns>
    public Scientific TotalNanojoules() {
        return this.ValueAs(MetricPrefix.Nano);
    }

    /// <summary>
    /// Create a length measured in Picojoules
    /// </summary>
    /// <param name="value">Picojoules</param>
    /// <returns>Energy</returns>
    public static Energy Picojoules(Scientific value) {
        return new Energy(value, MetricPrefix.Pico);
    }
    /// <summary>
    /// Total value of this length in Picojoules
    /// </summary>
    /// <returns>Picojoules</returns>
    public Scientific TotalPicojoules() {
        return this.ValueAs(MetricPrefix.Pico);
    }

    /// <summary>
    /// Create a length measured in Femtojoules
    /// </summary>
    /// <param name="value">Femtojoules</param>
    /// <returns>Energy</returns>
    public static Energy Femtojoules(Scientific value) {
        return new Energy(value, MetricPrefix.Femto);
    }
    /// <summary>
    /// Total value of this length in Femtojoules
    /// </summary>
    /// <returns>Femtojoules</returns>
    public Scientific TotalFemtojoules() {
        return this.ValueAs(MetricPrefix.Femto);
    }

    /// <summary>
    /// Create a length measured in Attojoules
    /// </summary>
    /// <param name="value">Attojoules</param>
    /// <returns>Energy</returns>
    public static Energy Attojoules(Scientific value) {
        return new Energy(value, MetricPrefix.Atto);
    }
    /// <summary>
    /// Total value of this length in Attojoules
    /// </summary>
    /// <returns>Attojoules</returns>
    public Scientific TotalAttojoules() {
        return this.ValueAs(MetricPrefix.Atto);
    }

    /// <summary>
    /// Create a length measured in Zeptojoules
    /// </summary>
    /// <param name="value">Zeptojoules</param>
    /// <returns>Energy</returns>
    public static Energy Zeptojoules(Scientific value) {
        return new Energy(value, MetricPrefix.Zepto);
    }
    /// <summary>
    /// Total value of this length in Zeptojoules
    /// </summary>
    /// <returns>Zeptojoules</returns>
    public Scientific TotalZeptojoules() {
        return this.ValueAs(MetricPrefix.Zepto);
    }


    /// <summary>
    /// Create a length measured in Yoctojoules
    /// </summary>
    /// <param name="value">Yoctojoules</param>
    /// <returns>Energy</returns>
    public static Energy Yoctojoules(Scientific value) {
        return new Energy(value, MetricPrefix.Yocto);
    }
    /// <summary>
    /// Total value of this length in Yoctojoules
    /// </summary>
    /// <returns>Yoctojoules</returns>
    public Scientific TotalYoctojoules() {
        return this.ValueAs(MetricPrefix.Yocto);
    }

    #endregion

}

}