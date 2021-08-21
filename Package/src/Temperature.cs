using Qkmaxware.Numbers;

namespace Qkmaxware.Measurement {

/// <summary>
/// Measurement of a temperature
/// </summary>
public class Temperature : BaseMeasure {
    public static readonly Unit DefaultUnitOfMeasure = new Unit("Kelvin", "K");
    public override Unit UnitsOfMeasure => DefaultUnitOfMeasure;

    public static readonly Temperature Zero = new Temperature(Scientific.Zero);

    /// <summary>
    /// Create a new temperature limited by absolute 0
    /// </summary>
    /// <param name="temp">temperature in kelvins</param>
    /// <returns>temperature</returns>
    private Temperature(Scientific temp) : base(((double)temp) < 0 ? Scientific.Zero : temp) {}

    #region operators
    public static Temperature operator* (Scientific l, Temperature r) {
        return new Temperature(l + r.InternalValue);
    }
    public static Temperature operator* (Temperature l, Scientific r) {
        return new Temperature(l.InternalValue + r);
    }
    public static Temperature operator+ (Temperature l, Temperature r) {
        return new Temperature(l.InternalValue + r.InternalValue);
    }
    public static Temperature operator- (Temperature l, Temperature r) {
        return new Temperature(l.InternalValue - r.InternalValue);
    }
    #endregion

    /// <summary>
    /// Create a temperature measured in degrees Kelvin
    /// </summary>
    /// <param name="degrees">degrees</param>
    /// <returns>Temperature</returns>
    public static Temperature Kelvin(Scientific degrees) {
        return new Temperature(degrees);
    }

    /// <summary>
    /// Total temperature in degrees Kelvin
    /// </summary>
    /// <returns>Kelvin</returns>
    public Scientific TotalKelvin() {
        return InternalValue;
    }

    /// <summary>
    /// Create a temperature measured in degrees Celsius
    /// </summary>
    /// <param name="degrees">degrees</param>
    /// <returns>Temperature</returns>
    public static Temperature Celsius(Scientific degrees) {
        return Temperature.Kelvin(degrees + new Scientific(273_15, -2));
    }

    /// <summary>
    /// Total temperature in degrees Celsius
    /// </summary>
    /// <returns>Celsius</returns>
    public Scientific TotalCelsius() {
        return this.TotalKelvin() - new Scientific(273_15, -2);
    }

    /// <summary>
    /// Create a temperature measured in degrees Fahrenheit
    /// </summary>
    /// <param name="degrees">degrees</param>
    /// <returns>Temperature</returns>
    public static Temperature Fahrenheit(Scientific degrees) {
        return Temperature.Celsius((degrees - 32) * (5d/9d));
    }

    /// <summary>
    /// Total temperature in degrees Fahrenheit
    /// </summary>
    /// <returns>Fahrenheit</returns>
    public Scientific TotalFahrenheit() {
        return (this.TotalCelsius() * (9d/5d)) + 32;
    }
}

}