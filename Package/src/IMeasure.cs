namespace Qkmaxware.Measurement {

/// <summary>
/// Interface for describing the basic functionality of a measurement
/// </summary>
public interface IMeasure {
    /// <summary>
    /// Units in which "InternalValue" is relative to
    /// </summary>
    /// <value>stored units</value>
    Unit UnitsOfMeasure {get;}
}

}