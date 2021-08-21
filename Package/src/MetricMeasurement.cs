using System.Numerics;
using Qkmaxware.Numbers;

namespace Qkmaxware.Measurement {

/// <summary>
/// Prefixes used in the SI metric system
/// </summary>
public enum MetricPrefix {
    None = 0,

    Yotta = 24,
    Zetta = 21,
    Exa = 18,
    Peta = 15,
    Tera = 12,
    Giga = 9,
    Mega = 6,
    Kilo = 3,
    Hecto = 2,
    Deca = 1,

    // --

    Deci = -1,
    Centi = -2,
    Milli = -3,
    Micro = -6,
    Nano = -9,
    Pico = -12,
    Femto = -15,
    Atto = -18,
    Zepto = -21,
    Yocto = -24,
}

/// <summary>
/// Base class for measurements that use the metric system
/// </summary>
public abstract class MetricMeasurement : BaseMeasure {
    protected MetricMeasurement(Scientific value, MetricPrefix prefix) : base(value.x10((int)prefix)) {}

    public Scientific ValueAs(MetricPrefix prefix) {
        if (prefix == MetricPrefix.None) {
            return this.InternalValue;
        } else {
            var exponent = (int)prefix;
            return this.InternalValue.x10(-exponent);
        }
    }

}

}