using Qkmaxware.Numbers;

namespace Qkmaxware.Measurement {

/// <summary>
/// Measurement of mass
/// </summary>
public class Mass : MetricMeasurement {
    public static readonly Unit DefaultUnitOfMeasure = new Unit("Grams", "g");
    public override Unit UnitsOfMeasure => DefaultUnitOfMeasure;


    private Mass (Scientific value, MetricPrefix prefix) : base(value, prefix) {}

    #region operators
    public static Mass operator* (Scientific l, Mass r) {
        return new Mass(l + r.valueAs(MetricPrefix.None), MetricPrefix.None);
    }
    public static Mass operator* (Mass l, Scientific r) {
        return new Mass(l.valueAs(MetricPrefix.None) + r, MetricPrefix.None);
    }
    public static Mass operator+ (Mass l, Mass r) {
        return new Mass(l.valueAs(MetricPrefix.None) + r.valueAs(MetricPrefix.None), MetricPrefix.None);
    }
    public static Mass operator- (Mass l, Mass r) {
        return new Mass(l.valueAs(MetricPrefix.None) - r.valueAs(MetricPrefix.None), MetricPrefix.None);
    }
    #endregion

    #region metric constructors

    /// <summary>
    /// Create a mass measured in grams
    /// </summary>
    /// <param name="value">grams</param>
    /// <returns>Mass</returns>
    public static Mass Grams(Scientific value) {
        return new Mass(value, MetricPrefix.None);
    }
    /// <summary>
    /// Total value of this mass in grams
    /// </summary>
    /// <returns>grams</returns>
    public Scientific TotalGrams() {
        return this.valueAs(MetricPrefix.None);
    }

    /// <summary>
    /// Create a mass measured in Yottagrams
    /// </summary>
    /// <param name="value">Yottagrams</param>
    /// <returns>Mass</returns>
    public static Mass Yottagrams(Scientific value) {
        return new Mass(value, MetricPrefix.Yotta);
    }
    /// <summary>
    /// Total value of this mass in Yottagrams
    /// </summary>
    /// <returns>Yottagrams</returns>
    public Scientific TotalYottagrams() {
        return this.valueAs(MetricPrefix.Yotta);
    }

    /// <summary>
    /// Create a mass measured in Zettagrams
    /// </summary>
    /// <param name="value">Zettagrams</param>
    /// <returns>Mass</returns>
    public static Mass Zettagrams(Scientific value) {
        return new Mass(value, MetricPrefix.Zetta);
    }
    /// <summary>
    /// Total value of this mass in Zettagrams
    /// </summary>
    /// <returns>Zettagrams</returns>
    public Scientific TotalZettagrams() {
        return this.valueAs(MetricPrefix.Zetta);
    }

    /// <summary>
    /// Create a mass measured in Exagrams
    /// </summary>
    /// <param name="value">Exagrams</param>
    /// <returns>Mass</returns>
    public static Mass Exagrams(Scientific value) {
        return new Mass(value, MetricPrefix.Exa);
    }
    /// <summary>
    /// Total value of this mass in Exagrams
    /// </summary>
    /// <returns>Exagrams</returns>
    public Scientific TotalExagrams() {
        return this.valueAs(MetricPrefix.Exa);
    }

    /// <summary>
    /// Create a mass measured in Petagrams
    /// </summary>
    /// <param name="value">Petagrams</param>
    /// <returns>Mass</returns>
    public static Mass Petagrams(Scientific value) {
        return new Mass(value, MetricPrefix.Peta);
    }
    /// <summary>
    /// Total value of this mass in Petagrams
    /// </summary>
    /// <returns>Petagrams</returns>
    public Scientific TotalPetagrams() {
        return this.valueAs(MetricPrefix.Peta);
    }

    /// <summary>
    /// Create a mass measured in Teragrams
    /// </summary>
    /// <param name="value">Teragrams</param>
    /// <returns>Mass</returns>
    public static Mass Teragrams(Scientific value) {
        return new Mass(value, MetricPrefix.Tera);
    }
    /// <summary>
    /// Total value of this mass in Teragrams
    /// </summary>
    /// <returns>Teragrams</returns>
    public Scientific TotalTeragrams() {
        return this.valueAs(MetricPrefix.Tera);
    }

    /// <summary>
    /// Create a mass measured in Gigagrams
    /// </summary>
    /// <param name="value">Gigagrams</param>
    /// <returns>Mass</returns>
    public static Mass Gigagrams(Scientific value) {
        return new Mass(value, MetricPrefix.Giga);
    }
    /// <summary>
    /// Total value of this mass in Gigagrams
    /// </summary>
    /// <returns>Gigagrams</returns>
    public Scientific TotalGigagrams() {
        return this.valueAs(MetricPrefix.Giga);
    }

    /// <summary>
    /// Create a mass measured in Megagrams
    /// </summary>
    /// <param name="value">Megagrams</param>
    /// <returns>Mass</returns>
    public static Mass Megagrams(Scientific value) {
        return new Mass(value, MetricPrefix.Mega);
    }
    /// <summary>
    /// Total value of this mass in Megagrams
    /// </summary>
    /// <returns>Megagrams</returns>
    public Scientific TotalMegagrams() {
        return this.valueAs(MetricPrefix.Mega);
    }

    /// <summary>
    /// Create a mass measured in Kilograms
    /// </summary>
    /// <param name="value">Kilograms</param>
    /// <returns>Mass</returns>
    public static Mass Kilograms(Scientific value) {
        return new Mass(value, MetricPrefix.Kilo);
    }
    /// <summary>
    /// Total value of this mass in Kilograms
    /// </summary>
    /// <returns>Kilograms</returns>
    public Scientific TotalKilograms() {
        return this.valueAs(MetricPrefix.Kilo);
    }

    /// <summary>
    /// Create a mass measured in Hectograms
    /// </summary>
    /// <param name="value">Hectograms</param>
    /// <returns>Mass</returns>
    public static Mass Hectograms(Scientific value) {
        return new Mass(value, MetricPrefix.Hecto);
    }
    /// <summary>
    /// Total value of this mass in Hectograms
    /// </summary>
    /// <returns>Hectograms</returns>
    public Scientific TotalHectograms() {
        return this.valueAs(MetricPrefix.Hecto);
    }

    /// <summary>
    /// Create a mass measured in Decagrams
    /// </summary>
    /// <param name="value">Decagrams</param>
    /// <returns>Mass</returns>
    public static Mass Decagrams(Scientific value) {
        return new Mass(value, MetricPrefix.Deca);
    }
    /// <summary>
    /// Total value of this mass in Decagrams
    /// </summary>
    /// <returns>Decagrams</returns>
    public Scientific TotalDecagrams() {
        return this.valueAs(MetricPrefix.Deca);
    }

    /// <summary>
    /// Create a mass measured in Decigrams
    /// </summary>
    /// <param name="value">Decigrams</param>
    /// <returns>Mass</returns>
    public static Mass Decigrams(Scientific value) {
        return new Mass(value, MetricPrefix.Deci);
    }
    /// <summary>
    /// Total value of this mass in Decigrams
    /// </summary>
    /// <returns>Decigrams</returns>
    public Scientific TotalDecigrams() {
        return this.valueAs(MetricPrefix.Deci);
    }

    /// <summary>
    /// Create a mass measured in Centigrams
    /// </summary>
    /// <param name="value">Centigrams</param>
    /// <returns>Mass</returns>
    public static Mass Centigrams(Scientific value) {
        return new Mass(value, MetricPrefix.Centi);
    }
    /// <summary>
    /// Total value of this mass in Centigrams
    /// </summary>
    /// <returns>Centigrams</returns>
    public Scientific TotalCentigrams() {
        return this.valueAs(MetricPrefix.Centi);
    }

    /// <summary>
    /// Create a mass measured in Milligrams
    /// </summary>
    /// <param name="value">Milligrams</param>
    /// <returns>Mass</returns>
    public static Mass Milligrams(Scientific value) {
        return new Mass(value, MetricPrefix.Milli);
    }
    /// <summary>
    /// Total value of this mass in Milligrams
    /// </summary>
    /// <returns>Milligrams</returns>
    public Scientific TotalMilligrams() {
        return this.valueAs(MetricPrefix.Milli);
    }

    /// <summary>
    /// Create a mass measured in Micrograms
    /// </summary>
    /// <param name="value">Micrograms</param>
    /// <returns>Mass</returns>
    public static Mass Micrograms(Scientific value) {
        return new Mass(value, MetricPrefix.Micro);
    }
    /// <summary>
    /// Total value of this mass in Micrograms
    /// </summary>
    /// <returns>Micrograms</returns>
    public Scientific TotalMicrograms() {
        return this.valueAs(MetricPrefix.Micro);
    }

    /// <summary>
    /// Create a mass measured in Nanograms
    /// </summary>
    /// <param name="value">Nanograms</param>
    /// <returns>Mass</returns>
    public static Mass Nanograms(Scientific value) {
        return new Mass(value, MetricPrefix.Nano);
    }
    /// <summary>
    /// Total value of this mass in Nanograms
    /// </summary>
    /// <returns>Nanograms</returns>
    public Scientific TotalNanograms() {
        return this.valueAs(MetricPrefix.Nano);
    }

    /// <summary>
    /// Create a mass measured in Picograms
    /// </summary>
    /// <param name="value">Picograms</param>
    /// <returns>Mass</returns>
    public static Mass Picograms(Scientific value) {
        return new Mass(value, MetricPrefix.Pico);
    }
    /// <summary>
    /// Total value of this mass in Picograms
    /// </summary>
    /// <returns>Picograms</returns>
    public Scientific TotalPicograms() {
        return this.valueAs(MetricPrefix.Pico);
    }

    /// <summary>
    /// Create a mass measured in Femtograms
    /// </summary>
    /// <param name="value">Femtograms</param>
    /// <returns>Mass</returns>
    public static Mass Femtograms(Scientific value) {
        return new Mass(value, MetricPrefix.Femto);
    }
    /// <summary>
    /// Total value of this mass in Femtograms
    /// </summary>
    /// <returns>Femtograms</returns>
    public Scientific TotalFemtograms() {
        return this.valueAs(MetricPrefix.Femto);
    }

    /// <summary>
    /// Create a mass measured in Attograms
    /// </summary>
    /// <param name="value">Attograms</param>
    /// <returns>Mass</returns>
    public static Mass Attograms(Scientific value) {
        return new Mass(value, MetricPrefix.Atto);
    }
    /// <summary>
    /// Total value of this mass in Attograms
    /// </summary>
    /// <returns>Attograms</returns>
    public Scientific TotalAttograms() {
        return this.valueAs(MetricPrefix.Atto);
    }

    /// <summary>
    /// Create a mass measured in Zeptograms
    /// </summary>
    /// <param name="value">Zeptograms</param>
    /// <returns>Mass</returns>
    public static Mass Zeptograms(Scientific value) {
        return new Mass(value, MetricPrefix.Zepto);
    }
    /// <summary>
    /// Total value of this mass in Zeptograms
    /// </summary>
    /// <returns>Zeptograms</returns>
    public Scientific TotalZeptograms() {
        return this.valueAs(MetricPrefix.Zepto);
    }


    /// <summary>
    /// Create a mass measured in Yoctograms
    /// </summary>
    /// <param name="value">Yoctograms</param>
    /// <returns>Mass</returns>
    public static Mass Yoctograms(Scientific value) {
        return new Mass(value, MetricPrefix.Yocto);
    }
    /// <summary>
    /// Total value of this mass in Yoctograms
    /// </summary>
    /// <returns>Yoctograms</returns>
    public Scientific TotalYoctograms() {
        return this.valueAs(MetricPrefix.Yocto);
    }

    #endregion

}

}