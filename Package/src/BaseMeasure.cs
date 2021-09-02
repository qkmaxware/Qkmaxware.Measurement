using Qkmaxware.Numbers;

namespace Qkmaxware.Measurement {

/// <summary>
/// Base class for measurements
/// </summary>
public abstract class BaseMeasure : IMeasure, IConvertable<Scientific> {
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

    /// <summary>
    /// Convert this measure to a unitless value
    /// </summary>
    /// <param name="value">value</param>
    public void Convert(out Scientific value) {
        value = this.InternalValue;
    }

    public override string ToString() {
        return $"{InternalValue}{UnitsOfMeasure?.PrimarySymbol ?? string.Empty}";
    }

    public override bool Equals(object obj) {
        if (obj == null)
            return false;
        if (obj.GetType() == GetType()) {
            return this.InternalValue.Equals(((BaseMeasure)obj).InternalValue);
        } else {
            return false;
        }
    }
    
    // override object.GetHashCode
    public override int GetHashCode() {
        return this.InternalValue.GetHashCode();
    }
}

}