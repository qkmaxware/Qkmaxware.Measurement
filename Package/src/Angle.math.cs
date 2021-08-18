using System;
using Qkmaxware.Numbers;

namespace Qkmaxware.Measurement {

public partial class Angle {
    /// <summary>
    /// Returns the angle whose cosine is the specified number
    /// </summary>
    /// <param name="cosine">A number representing a cosine</param>
    /// <returns>Angle</returns>
    public static Angle Acos(double cosine) {
        return Angle.Radians(Math.Acos(cosine));
    }

    /// <summary>
    /// Returns the angle whose sine is the specified number
    /// </summary>
    /// <param name="sine">A number representing a sine</param>
    /// <returns>Angle</returns>
    public static Angle Asin(double sine) {
        return Angle.Radians(Math.Asin(sine));
    }

    /// <summary>
    /// Returns the angle whose tangent is the specified number
    /// </summary>
    /// <param name="tangent">A number representing a tangent</param>
    /// <returns>Angle</returns>
    public static Angle Atan(double tangent) {
        return Angle.Radians(Math.Atan(tangent));
    }

    /// <summary>
    /// Returns the angle whose tangent is the quotient of the two numbers
    /// </summary>
    /// <param name="y">The y coordinate</param>
    /// <param name="x">The x coordinate</param>
    /// <returns>Angle</returns>
    public static Angle Atan2(double y, double x) {
        return Angle.Radians(Math.Atan2(y, x));
    }

    /// <summary>
    /// Returns the cosine of the specified angle
    /// </summary>
    /// <param name="angle">An angle</param>
    /// <returns>cosine</returns>
    public static double Cos(Angle angle) {
        return Math.Cos((double)angle.TotalRadians());
    }

    /// <summary>
    /// Returns the cosine of the specified angle
    /// </summary>
    /// <returns>cosine</returns>
    public double Cos() {
        return Angle.Cos(this);
    }

    /// <summary>
    /// Returns the sine of the specified angle
    /// </summary>
    /// <param name="angle">An angle</param>
    /// <returns>sine</returns>
    public static double Sin(Angle angle) {
        return Math.Sin((double)angle.TotalRadians());
    }

    /// <summary>
    /// Returns the sine of the specified angle
    /// </summary>
    /// <returns>sine</returns>
    public double Sin() {
        return Angle.Sin(this);
    }

    /// <summary>
    /// Returns the tangent of the specified angle
    /// </summary>
    /// <param name="angle">An angle</param>
    /// <returns>tangent</returns>
    public static double Tan(Angle angle) {
        return Math.Tan((double)angle.TotalRadians());
    }

    /// <summary>
    /// Returns the tangent of the specified angle
    /// </summary>
    /// <returns>tangent</returns>
    public double Tan() {
        return Angle.Tan(this);
    }

}

}