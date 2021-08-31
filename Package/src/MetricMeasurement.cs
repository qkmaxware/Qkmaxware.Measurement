using System;
using System.Numerics;
using System.Linq;
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

public static class MetricPrefixTools {
    /// <summary>
    /// Get the prefix symbol for this metrix prefix
    /// </summary>
    /// <param name="prefix">metric prefix</param>
    /// <returns>prefix symbol</returns>
    public static string GetPrefixSymbol(this MetricPrefix prefix) {
        return prefix switch {

            MetricPrefix.Yotta => "Y",
            MetricPrefix.Zetta => "Z",
            MetricPrefix.Exa => "E",
            MetricPrefix.Peta => "P",
            MetricPrefix.Tera => "T",
            MetricPrefix.Giga => "G",
            MetricPrefix.Mega => "M",
            MetricPrefix.Kilo => "k",
            MetricPrefix.Hecto => "h",
            MetricPrefix.Deca => "da",

            // --

            MetricPrefix.Deci => "d",
            MetricPrefix.Centi => "c",
            MetricPrefix.Milli => "m",
            MetricPrefix.Micro => "μ",
            MetricPrefix.Nano => "n",
            MetricPrefix.Pico => "p",
            MetricPrefix.Femto => "f",
            MetricPrefix.Atto => "a",
            MetricPrefix.Zepto => "z",
            MetricPrefix.Yocto => "y",

            _ => string.Empty
        };
    }
    /// <summary>
    /// Attempt to determine the metric prefix for the given symbol
    /// </summary>
    /// <param name="symbol">symbol</param>
    /// <returns>metric prefix</returns>
    public static MetricPrefix ParsePrefix(string symbol) {
        if (string.IsNullOrEmpty(symbol)) {
            return MetricPrefix.None;
        }
        if (symbol.StartsWith("da")) {
            return MetricPrefix.Deca;
        } else {
            char c = symbol[0];
            return c switch {
                'Y' => MetricPrefix.Yotta, 
                'Z' => MetricPrefix.Zetta, 
                'E' => MetricPrefix.Exa  , 
                'P' => MetricPrefix.Peta , 
                'T' => MetricPrefix.Tera , 
                'G' => MetricPrefix.Giga , 
                'M' => MetricPrefix.Mega , 
                'k' => MetricPrefix.Kilo , 
                'h' => MetricPrefix.Hecto, 
                // Deca goes here, but deca has 2 characters so it is handled earlier

                // --

                'd' => MetricPrefix.Deci ,
                'c' => MetricPrefix.Centi,
                'm' => MetricPrefix.Milli,
                'μ' => MetricPrefix.Micro,
                'n' => MetricPrefix.Nano ,
                'p' => MetricPrefix.Pico ,
                'f' => MetricPrefix.Femto,
                'a' => MetricPrefix.Atto ,
                'z' => MetricPrefix.Zepto,
                'y' => MetricPrefix.Yocto,

                _ => MetricPrefix.None
            };
        }
    }
}

/// <summary>
/// Base class for measurements that use the metric system
/// </summary>
public abstract class MetricMeasurement : BaseMeasure {
    protected MetricMeasurement(Scientific value, MetricPrefix prefix) : base(value.x10((int)prefix)) {}

    /// <summary>
    /// Get the preferred metric scale based on the size of the measurement
    /// </summary>
    /// <returns>Closest scale to the measurement</returns>
    public MetricPrefix PreferredScale {
        get {
            var prefixes = (MetricPrefix[])Enum.GetValues(typeof(MetricPrefix));
            return prefixes.OrderBy(prefix => Math.Abs((int)prefix - this.InternalValue.Exponent)).First();
        }
    }

    /// <summary>
    /// Get the metric value scaled to the given prefix
    /// </summary>
    /// <param name="prefix">metric prefix</param>
    /// <returns>scaled value</returns>
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