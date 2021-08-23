using Qkmaxware.Numbers;

namespace Qkmaxware.Measurement {

/// <summary>
/// Base class for measured that are derived from other measurements
/// </summary>
public abstract class DerivedMeasure : IMeasure, IConvertable<Scientific> {
    /// <summary>
    /// Units in which "InternalValue" is relative to
    /// </summary>
    /// <value>stored units</value>
    public abstract Unit UnitsOfMeasure {get;}

    /// <summary>
    /// Convert this measure to a unitless value
    /// </summary>
    /// <param name="value">value</param>
    public abstract void Convert(out Scientific value);
}
    
}