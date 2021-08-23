using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Qkmaxware.Numbers;

namespace Qkmaxware.Measurement {

/// <summary>
/// Unit of measure class
/// </summary>
public class Unit {
    /// <summary>
    /// Name of the unit of measure
    /// </summary>
    /// <value>long name</value>
    public string Name {get; private set;}
    /// <summary>
    /// Primary symbol used to denote a measurement relative to this unit of measure
    /// </summary>
    /// <value>mathematical symbol</value>
    public string PrimarySymbol {get; private set;}
    private List<string> _secondarySymbols {get; set;}
    /// <summary>
    /// Secondary symbols used that can be used alternatively to the Primary Symbol
    /// </summary>
    /// <value>collection of mathematical symbols</value>
    public ReadOnlyCollection<string> SecondarySymbols => _secondarySymbols.AsReadOnly();

    /// <summary>
    /// Create a new unit of measure
    /// </summary>
    /// <param name="name">name</param>
    /// <param name="symbol">primary mathematical symbol</param>
    /// <param name="extraSymbols">list of alternative symbols</param>
    public Unit(string name, string symbol, params string[] extraSymbols) {
        this.Name = name;
        this.PrimarySymbol = symbol;
        this._secondarySymbols = new List<string>(extraSymbols ?? new string[0]);
    }

    /// <summary>
    /// Create a new unit of measure
    /// </summary>
    /// <param name="name">name</param>
    /// <param name="symbol">primary mathematical symbol</param>
    /// <param name="extraSymbols">list of alternative symbols</param>
    public Unit(string name, string symbol, List<string> extraSymbols) {
        this.Name = name;
        this.PrimarySymbol = symbol;
        this._secondarySymbols = new List<string>(extraSymbols);
    }

    /// <summary>
    /// Create a derived unit through division
    /// </summary>
    /// <param name="lhs">left hand of the division</param>
    /// <param name="rhs">right hand of the division</param>
    /// <returns>new unit of measure</returns>
    public static Unit operator / (Unit lhs, Unit rhs) {
        var name = $"{lhs.Name} Per {rhs.Name}";
        var primary = $"{lhs.PrimarySymbol}/{rhs.PrimarySymbol}";
        List<string> options = new List<string>(lhs.SecondarySymbols.Count * rhs.SecondarySymbols.Count);
        for (var i = 0; i < lhs.SecondarySymbols.Count; i++) {
            for (var j = 0; j < rhs.SecondarySymbols.Count; i++) {
                options.Add($"{lhs.SecondarySymbols[i]}/{rhs.SecondarySymbols[j]}");
            }
        }
        return new Unit(name, primary, options);
    }

    // override object.Equals
    public override bool Equals(object obj){
        //
        // See the full list of guidelines at
        //   http://go.microsoft.com/fwlink/?LinkID=85237
        // and also the guidance for operator== at
        //   http://go.microsoft.com/fwlink/?LinkId=85238
        //
        
        if (obj == null || GetType() != obj.GetType()){
            return false;
        }
        
        // TODO: write your implementation of Equals() here
        var ot = (Unit)obj;
        return this.Name == ot.Name && this.PrimarySymbol == ot.PrimarySymbol;
    }
    
    // override object.GetHashCode
    public override int GetHashCode() {
        return (this.Name, this.PrimarySymbol).GetHashCode();
    }
}

}