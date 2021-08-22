using Qkmaxware.Numbers;

namespace Qkmaxware.Measurement {

/// <summary>
/// A measurement of length or distance
/// </summary>
public class Force : MetricMeasurement, INumeric<Force>, IScalable<Scientific, Force> {
    public static readonly Unit DefaultUnitOfMeasure = new Unit("Newtons", "N");
    public override Unit UnitsOfMeasure => DefaultUnitOfMeasure;

    public static readonly Force Zero = new Force(0, MetricPrefix.None);

    private Force (Scientific value, MetricPrefix prefix) : base(value, prefix) {}

    #region operators
    public Force ScaleBy(Scientific scalar) => new Force(scalar * this.ValueAs(MetricPrefix.None), MetricPrefix.None);
    public Force Negate() {
        return new Force(-1 * this.ValueAs(MetricPrefix.None), MetricPrefix.None);
    }

    public Force Sqrt() {
        return new Force(this.ValueAs(MetricPrefix.None).Sqrt(), MetricPrefix.None);
    }

    public Force Add(Force rhs) {
        return this + rhs;
    }

    public Force Subtract(Force rhs) {
        return this - rhs;
    }

    public Force MultiplyBy(Force rhs) {
        return new Force(this.ValueAs(MetricPrefix.None) * rhs.ValueAs(MetricPrefix.None), MetricPrefix.None);
    }

    public Force DivideBy(Force rhs) {
        return new Force(this.ValueAs(MetricPrefix.None) / rhs.ValueAs(MetricPrefix.None), MetricPrefix.None);
    }
    
    public static Force operator* (Scientific l, Force r) {
        return new Force(l * r.ValueAs(MetricPrefix.None), MetricPrefix.None);
    }
    public static Force operator* (Force l, Scientific r) {
        return new Force(l.ValueAs(MetricPrefix.None) * r, MetricPrefix.None);
    }
    public static Force operator+ (Force l, Force r) {
        return new Force(l.ValueAs(MetricPrefix.None) + r.ValueAs(MetricPrefix.None), MetricPrefix.None);
    }
    public static Force operator- (Force l, Force r) {
        return new Force(l.ValueAs(MetricPrefix.None) - r.ValueAs(MetricPrefix.None), MetricPrefix.None);
    }
    #endregion

    #region metric constructors

    /// <summary>
    /// Create a length measured in newtons
    /// </summary>
    /// <param name="value">newtons</param>
    /// <returns>Force</returns>
    public static Force Newtons(Scientific value) {
        return new Force(value, MetricPrefix.None);
    }
    /// <summary>
    /// Total value of this length in newtons
    /// </summary>
    /// <returns>newtons</returns>
    public Scientific TotalNewtons() {
        return this.ValueAs(MetricPrefix.None);
    }

    /// <summary>
    /// Create a length measured in Yottanewtons
    /// </summary>
    /// <param name="value">Yottanewtons</param>
    /// <returns>Force</returns>
    public static Force Yottanewtons(Scientific value) {
        return new Force(value, MetricPrefix.Yotta);
    }
    /// <summary>
    /// Total value of this length in Yottanewtons
    /// </summary>
    /// <returns>Yottanewtons</returns>
    public Scientific TotalYottanewtons() {
        return this.ValueAs(MetricPrefix.Yotta);
    }

    /// <summary>
    /// Create a length measured in Zettanewtons
    /// </summary>
    /// <param name="value">Zettanewtons</param>
    /// <returns>Force</returns>
    public static Force Zettanewtons(Scientific value) {
        return new Force(value, MetricPrefix.Zetta);
    }
    /// <summary>
    /// Total value of this length in Zettanewtons
    /// </summary>
    /// <returns>Zettanewtons</returns>
    public Scientific TotalZettanewtons() {
        return this.ValueAs(MetricPrefix.Zetta);
    }

    /// <summary>
    /// Create a length measured in Exanewtons
    /// </summary>
    /// <param name="value">Exanewtons</param>
    /// <returns>Force</returns>
    public static Force Exanewtons(Scientific value) {
        return new Force(value, MetricPrefix.Exa);
    }
    /// <summary>
    /// Total value of this length in Exanewtons
    /// </summary>
    /// <returns>Exanewtons</returns>
    public Scientific TotalExanewtons() {
        return this.ValueAs(MetricPrefix.Exa);
    }

    /// <summary>
    /// Create a length measured in Petanewtons
    /// </summary>
    /// <param name="value">Petanewtons</param>
    /// <returns>Force</returns>
    public static Force Petanewtons(Scientific value) {
        return new Force(value, MetricPrefix.Peta);
    }
    /// <summary>
    /// Total value of this length in Petanewtons
    /// </summary>
    /// <returns>Petanewtons</returns>
    public Scientific TotalPetanewtons() {
        return this.ValueAs(MetricPrefix.Peta);
    }

    /// <summary>
    /// Create a length measured in Teranewtons
    /// </summary>
    /// <param name="value">Teranewtons</param>
    /// <returns>Force</returns>
    public static Force Teranewtons(Scientific value) {
        return new Force(value, MetricPrefix.Tera);
    }
    /// <summary>
    /// Total value of this length in Teranewtons
    /// </summary>
    /// <returns>Teranewtons</returns>
    public Scientific TotalTeranewtons() {
        return this.ValueAs(MetricPrefix.Tera);
    }

    /// <summary>
    /// Create a length measured in Giganewtons
    /// </summary>
    /// <param name="value">Giganewtons</param>
    /// <returns>Force</returns>
    public static Force Giganewtons(Scientific value) {
        return new Force(value, MetricPrefix.Giga);
    }
    /// <summary>
    /// Total value of this length in Giganewtons
    /// </summary>
    /// <returns>Giganewtons</returns>
    public Scientific TotalGiganewtons() {
        return this.ValueAs(MetricPrefix.Giga);
    }

    /// <summary>
    /// Create a length measured in Meganewtons
    /// </summary>
    /// <param name="value">Meganewtons</param>
    /// <returns>Force</returns>
    public static Force Meganewtons(Scientific value) {
        return new Force(value, MetricPrefix.Mega);
    }
    /// <summary>
    /// Total value of this length in Meganewtons
    /// </summary>
    /// <returns>Meganewtons</returns>
    public Scientific TotalMeganewtons() {
        return this.ValueAs(MetricPrefix.Mega);
    }

    /// <summary>
    /// Create a length measured in Kilonewtons
    /// </summary>
    /// <param name="value">Kilonewtons</param>
    /// <returns>Force</returns>
    public static Force Kilonewtons(Scientific value) {
        return new Force(value, MetricPrefix.Kilo);
    }
    /// <summary>
    /// Total value of this length in Kilonewtons
    /// </summary>
    /// <returns>Kilonewtons</returns>
    public Scientific TotalKilonewtons() {
        return this.ValueAs(MetricPrefix.Kilo);
    }

    /// <summary>
    /// Create a length measured in Hectonewtons
    /// </summary>
    /// <param name="value">Hectonewtons</param>
    /// <returns>Force</returns>
    public static Force Hectonewtons(Scientific value) {
        return new Force(value, MetricPrefix.Hecto);
    }
    /// <summary>
    /// Total value of this length in Hectonewtons
    /// </summary>
    /// <returns>Hectonewtons</returns>
    public Scientific TotalHectonewtons() {
        return this.ValueAs(MetricPrefix.Hecto);
    }

    /// <summary>
    /// Create a length measured in Decanewtons
    /// </summary>
    /// <param name="value">Decanewtons</param>
    /// <returns>Force</returns>
    public static Force Decanewtons(Scientific value) {
        return new Force(value, MetricPrefix.Deca);
    }
    /// <summary>
    /// Total value of this length in Decanewtons
    /// </summary>
    /// <returns>Decanewtons</returns>
    public Scientific TotalDecanewtons() {
        return this.ValueAs(MetricPrefix.Deca);
    }

    /// <summary>
    /// Create a length measured in Decinewtons
    /// </summary>
    /// <param name="value">Decinewtons</param>
    /// <returns>Force</returns>
    public static Force Decinewtons(Scientific value) {
        return new Force(value, MetricPrefix.Deci);
    }
    /// <summary>
    /// Total value of this length in Decinewtons
    /// </summary>
    /// <returns>Decinewtons</returns>
    public Scientific TotalDecinewtons() {
        return this.ValueAs(MetricPrefix.Deci);
    }

    /// <summary>
    /// Create a length measured in Centinewtons
    /// </summary>
    /// <param name="value">Centinewtons</param>
    /// <returns>Force</returns>
    public static Force Centinewtons(Scientific value) {
        return new Force(value, MetricPrefix.Centi);
    }
    /// <summary>
    /// Total value of this length in Centinewtons
    /// </summary>
    /// <returns>Centinewtons</returns>
    public Scientific TotalCentinewtons() {
        return this.ValueAs(MetricPrefix.Centi);
    }

    /// <summary>
    /// Create a length measured in Millinewtons
    /// </summary>
    /// <param name="value">Millinewtons</param>
    /// <returns>Force</returns>
    public static Force Millinewtons(Scientific value) {
        return new Force(value, MetricPrefix.Milli);
    }
    /// <summary>
    /// Total value of this length in Millinewtons
    /// </summary>
    /// <returns>Millinewtons</returns>
    public Scientific TotalMillinewtons() {
        return this.ValueAs(MetricPrefix.Milli);
    }

    /// <summary>
    /// Create a length measured in Micronewtons
    /// </summary>
    /// <param name="value">Micronewtons</param>
    /// <returns>Force</returns>
    public static Force Micronewtons(Scientific value) {
        return new Force(value, MetricPrefix.Micro);
    }
    /// <summary>
    /// Total value of this length in Micronewtons
    /// </summary>
    /// <returns>Micronewtons</returns>
    public Scientific TotalMicronewtons() {
        return this.ValueAs(MetricPrefix.Micro);
    }

    /// <summary>
    /// Create a length measured in Nanonewtons
    /// </summary>
    /// <param name="value">Nanonewtons</param>
    /// <returns>Force</returns>
    public static Force Nanonewtons(Scientific value) {
        return new Force(value, MetricPrefix.Nano);
    }
    /// <summary>
    /// Total value of this length in Nanonewtons
    /// </summary>
    /// <returns>Nanonewtons</returns>
    public Scientific TotalNanonewtons() {
        return this.ValueAs(MetricPrefix.Nano);
    }

    /// <summary>
    /// Create a length measured in Piconewtons
    /// </summary>
    /// <param name="value">Piconewtons</param>
    /// <returns>Force</returns>
    public static Force Piconewtons(Scientific value) {
        return new Force(value, MetricPrefix.Pico);
    }
    /// <summary>
    /// Total value of this length in Piconewtons
    /// </summary>
    /// <returns>Piconewtons</returns>
    public Scientific TotalPiconewtons() {
        return this.ValueAs(MetricPrefix.Pico);
    }

    /// <summary>
    /// Create a length measured in Femtonewtons
    /// </summary>
    /// <param name="value">Femtonewtons</param>
    /// <returns>Force</returns>
    public static Force Femtonewtons(Scientific value) {
        return new Force(value, MetricPrefix.Femto);
    }
    /// <summary>
    /// Total value of this length in Femtonewtons
    /// </summary>
    /// <returns>Femtonewtons</returns>
    public Scientific TotalFemtonewtons() {
        return this.ValueAs(MetricPrefix.Femto);
    }

    /// <summary>
    /// Create a length measured in Attonewtons
    /// </summary>
    /// <param name="value">Attonewtons</param>
    /// <returns>Force</returns>
    public static Force Attonewtons(Scientific value) {
        return new Force(value, MetricPrefix.Atto);
    }
    /// <summary>
    /// Total value of this length in Attonewtons
    /// </summary>
    /// <returns>Attonewtons</returns>
    public Scientific TotalAttonewtons() {
        return this.ValueAs(MetricPrefix.Atto);
    }

    /// <summary>
    /// Create a length measured in Zeptonewtons
    /// </summary>
    /// <param name="value">Zeptonewtons</param>
    /// <returns>Force</returns>
    public static Force Zeptonewtons(Scientific value) {
        return new Force(value, MetricPrefix.Zepto);
    }
    /// <summary>
    /// Total value of this length in Zeptonewtons
    /// </summary>
    /// <returns>Zeptonewtons</returns>
    public Scientific TotalZeptonewtons() {
        return this.ValueAs(MetricPrefix.Zepto);
    }


    /// <summary>
    /// Create a length measured in Yoctonewtons
    /// </summary>
    /// <param name="value">Yoctonewtons</param>
    /// <returns>Force</returns>
    public static Force Yoctonewtons(Scientific value) {
        return new Force(value, MetricPrefix.Yocto);
    }
    /// <summary>
    /// Total value of this length in Yoctonewtons
    /// </summary>
    /// <returns>Yoctonewtons</returns>
    public Scientific TotalYoctonewtons() {
        return this.ValueAs(MetricPrefix.Yocto);
    }

    #endregion

}

}