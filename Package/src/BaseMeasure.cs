using Qkmaxware.Numbers;

namespace Qkmaxware.Measurement {

/// <summary>
/// Base class for measurements
/// </summary>
public abstract class BaseMeasure : IMeasure {
    /// <summary>
    /// Internally stored value with units "InternalUnits"
    /// </summary>
    /// <value>stored value</value>
    protected Scientific InternalValue {get; private set;}
    /// <summary>
    /// Units in which "InternalValue" is relative to
    /// </summary>
    /// <value>stored units</value>
    public abstract Unit UnitsOfMeasure {get;}

    /// <summary>
    /// Default constructor
    /// </summary>
    /// <param name="real">internal value in the internal units</param>
    protected BaseMeasure(Scientific real) {
        this.InternalValue = real;
    }

    public override string ToString() {
        return $"{InternalValue}{UnitsOfMeasure?.PrimarySymbol ?? string.Empty}";
    }
}

}