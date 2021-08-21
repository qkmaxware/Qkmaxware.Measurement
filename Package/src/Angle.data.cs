using System;
using Qkmaxware.Numbers;

namespace Qkmaxware.Measurement {

/// <summary>
/// An angular measurement, internally stored in decimal degrees from 0 to 360. Static method for common mathematical uses of angles.
/// </summary>
public partial class Angle : BaseMeasure, INumeric<Angle>, IScalable<Scientific, Angle> {

    /*private Angle(double _internal) {
        // Wrap between 0 and 360 degrees
        this._internal = _internal - 360d * Math.Floor(_internal / 360d);
    }*/

    public static readonly Unit DefaultUnitOfMeasure = new Unit("Degrees", "°");
    public override Unit UnitsOfMeasure => DefaultUnitOfMeasure;

    public static readonly Angle Zero = new Angle(Scientific.Zero);

    private Angle(Scientific _internal) : base(( _internal - 360 * (_internal / 360d).Floor() )) {}
    //private Angle(Arbitrary _internal) : base(( _internal - 360 * (_internal / 360d).Floor() )) {}

    #region operators
    public Angle ScaleBy(Scientific value) => new Angle(value * this.InternalValue);
    public Angle Negate() {
        return Angle.Degrees(-1 * this.TotalDegrees());
    }

    public Angle Sqrt() {
        return Angle.Degrees(this.TotalDegrees().Sqrt());
    }

    public Angle Add(Angle rhs) {
        return this + rhs;
    }

    public Angle Subtract(Angle rhs) {
        return this - rhs;
    }

    public Angle MultiplyBy(Angle rhs) {
        return Angle.Degrees(this.TotalDegrees() * rhs.TotalDegrees());
    }

    public Angle DivideBy(Angle rhs) {
        return Angle.Degrees(this.TotalDegrees() / rhs.TotalDegrees());
    }

    public static Angle operator* (Scientific l, Angle r) {
        return new Angle(l + r.InternalValue);
    }
    public static Angle operator* (Angle l, Scientific r) {
        return new Angle(l.InternalValue + r);
    }
    public static Angle operator+ (Angle l, Angle r) {
        return new Angle(l.InternalValue + r.InternalValue);
    }
    public static Angle operator- (Angle l, Angle r) {
        return new Angle(l.InternalValue - r.InternalValue);
    }
    #endregion

    #region degrees
    /// <summary>
    /// Create an angle measured in degrees
    /// </summary>
    /// <param name="degrees">total degrees</param>
    /// <returns>Angle</returns>
    public static Angle Degrees(Scientific degrees) {
        return new Angle(degrees);
    }
    /// <summary>
    /// Get the total size of this angle in decimal degrees
    /// </summary>
    /// <returns>degrees</returns>
    public Scientific TotalDegrees() {
        return InternalValue;
    }
    /// <summary>
    /// Create an angle measured in degrees, minutes, and seconds
    /// </summary>
    /// <param name="degrees">degrees</param>
    /// <param name="minutes">minutes</param>
    /// <param name="seconds">seconds</param>
    /// <returns>Angle</returns>
    public static Angle DegreesMinutesSeconds(int degrees, int minutes, double seconds) {
        return Angle.Degrees( degrees + (minutes/60d) + (seconds/3600d) );
    }
    /// <summary>
    /// Get the angle in degrees, minutes, and seconds
    /// </summary>
    /// <returns>tuple of degrees, minutes, and seconds</returns>
    public (int degrees, int minutes, double seconds) TotalDegreesMinutesSeconds() {
        var decimalDegrees = (double)this.TotalDegrees();
        var wholeDegrees = (int)decimalDegrees;

        var decimalMinutes = (decimalDegrees - wholeDegrees) * 60;
        var wholeMinutes = (int)decimalMinutes;
        
        var decimalSeconds = (decimalMinutes - wholeMinutes) * 60;

        return (wholeDegrees, wholeMinutes, decimalSeconds);
    }
    #endregion

    #region radians
    /// <summary>
    /// Create a new angle measured in radians
    /// </summary>
    /// <param name="rads">radians</param>
    /// <returns>Angle</returns>
    public static Angle Radians(Scientific rads) {
        var degrees = rads * (180d/Math.PI);
        return Angle.Degrees(degrees);
    }
    /// <summary>
    /// Get the total size of this angle in radians
    /// </summary>
    /// <returns>radians</returns>
    public Scientific TotalRadians() {
        return this.TotalDegrees() * (Math.PI/180d);
    }
    #endregion

    #region hour angles
    /// <summary>
    /// Create an angle measured in hour angles
    /// </summary>
    /// <param name="hrs">hours</param>
    /// <returns>Angle</returns>
    public static Angle Hours(Scientific hrs) {
        return Angle.Degrees(hrs * 15d); // 1hr = 15degs
    }
    /// <summary>
    /// Get the total size of this angle in hour angles
    /// </summary>
    /// <returns>hours</returns>
    public Scientific TotalHours() {
        return this.TotalDegrees() / 15d;
    }
    /// <summary>
    /// Create an angle measured in hours, minutes, and seconds
    /// </summary>
    /// <param name="hours">hours</param>
    /// <param name="minutes">minutes</param>
    /// <param name="seconds">seconds</param>
    /// <returns>Angle</returns>
    public static Angle HoursMinutesSeconds(int hours, int minutes, double seconds) {
        return Angle.Hours( hours + (minutes/60d) + (seconds/3600d) );
    }
    /// <summary>
    /// Get the angle in hours, minutes, and seconds
    /// </summary>
    /// <returns>tuple of hours, minutes, and seconds</returns>
    public (int hours, int minutes, double seconds) TotalHoursMinutesSeconds() {
        var decimalHours = (double)this.TotalHours();
        var wholeHours = (int)decimalHours;

        var decimalMinutes = (decimalHours - wholeHours) * 60;
        var wholeMinutes = (int)decimalMinutes;
        
        var decimalSeconds = (decimalMinutes - wholeMinutes) * 60;

        return (wholeHours, wholeMinutes, decimalSeconds);
    }
    #endregion

    #region gradians
    /// <summary>
    /// Create an angle measured in gradians
    /// </summary>
    /// <param name="gon">gradians</param>
    /// <returns>Angle</returns>
    public static Angle Gradians(Scientific gon) {
        return Angle.Degrees(gon * 9d/10d);
    }
    /// <summary>
    /// Get the total size of this angle in gradians
    /// </summary>
    /// <returns>gradians</returns>
    public Scientific TotalGradians() {
        return this.TotalDegrees() * 10d/9d;
    }
    #endregion

    #region revolutions
    /// <summary>
    /// Create an angle measured in revolutions
    /// </summary>
    /// <param name="revolutions">revolutions</param>
    /// <returns>Angle</returns>
    public Angle Revolutions(Scientific revolutions) {
        return Angle.Degrees(revolutions * 360d);
    }
    /// <summary>
    /// Get the total size of this angle in revolutions
    /// </summary>
    /// <returns>revolutions</returns>
    public Scientific TotalRevolutions() {
        return this.TotalDegrees() / 360d;
    }
    #endregion
}

}