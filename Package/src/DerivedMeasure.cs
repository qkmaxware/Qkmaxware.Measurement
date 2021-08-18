namespace Qkmaxware.Measurement {

/// <summary>
/// Base class for measured that are derived from other measurements
/// </summary>
public abstract class DerivedMeasure : IMeasure {
    /// <summary>
    /// Units in which "InternalValue" is relative to
    /// </summary>
    /// <value>stored units</value>
    public abstract Unit UnitsOfMeasure {get;}
}
    
}