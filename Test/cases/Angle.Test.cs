using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Qkmaxware.Numbers;

namespace Qkmaxware.Measurement {

[TestClass]
public class AngleTest {
    [TestMethod]
    public void TestAngleWrapping() {
        Angle a = null;
        
        // Positive angles
        a = Angle.Degrees(45);
        Assert.AreEqual(45, (double)a.TotalDegrees(), 0.00000000001);

        a = Angle.Degrees(90);  
        Assert.AreEqual(90, (double)a.TotalDegrees(), 0.00000000001);

        a = Angle.Degrees(300);
        Assert.AreEqual(300, (double)a.TotalDegrees(), 0.00000000001);

        a = Angle.Degrees(400);
        Assert.AreEqual(40, (double)a.TotalDegrees(), 0.00000000001);

        // Negative angles
        a = Angle.Degrees(-90);
        Assert.AreEqual(270, (double)a.TotalDegrees(), 0.00000000001);

        a = Angle.Degrees(-300);
        Assert.AreEqual(60, (double)a.TotalDegrees(), 0.00000000001);

        a = Angle.Degrees(-400);
        Assert.AreEqual(320, (double)a.TotalDegrees(), 0.00000000001);
    }

    [TestMethod]
    public void TestLargeAngles() {
        var angle = Angle.Degrees(192_725.469); // Wrapping in double precision (will introduce some error)
        Assert.AreEqual(125.469, (double)angle.TotalDegrees(), 0.1);

        var raw = 192_725_469.x10(-3);
        angle = Angle.Degrees(raw); // Will perform wrapping in high precision before downcasting

        Assert.AreEqual(125.469, (double)angle.TotalDegrees(), 0.0001);
    }

    [TestMethod]
    public void TestDegrees() {
        var a = Angle.Degrees(10.46);
        Assert.AreEqual(10.46, a.TotalDegrees());

        var (deg, min, s) = a.TotalDegreesMinutesSeconds();
        Assert.AreEqual(10, deg);
        Assert.AreEqual(27, min);
        Assert.AreEqual(36, s, 0.1);
    }

    [TestMethod]
    public void TestRadians() {
        var pi = System.Math.PI;
        var degrees = new double[]{0, 30, 45, 60, 90, 120, 135, 180, 225, 270, 315};
        var radians = new double[]{0, pi/6, pi/4, pi/3, pi/2, 2*pi/3, 3*pi/4, pi, 5*pi/4, 3*pi/2, 7*pi/4};
        
        for (var i = 0; i < System.Math.Min(degrees.Length, radians.Length); i++) {
            var a = Angle.Radians(radians[i]);
            Assert.AreEqual(radians[i], (double)a.TotalRadians(), 0.0001, $"Incorrectly stored {radians[i]}rads");
            Assert.AreEqual(degrees[i], (double)a.TotalDegrees(), 0.0001, $"Incorrectly converted {radians[i]}rads should be {degrees[i]}, but is {a.TotalDegrees()}");
        }
    }

    [TestMethod]
    public void TestHourAngles() {
        var degrees = new double[]{0, 15, 30, 45, 60, 75, 90, 105, 120, 135, 150, 300};
        var hours   = new double[]{0, 01, 02, 03, 04, 05, 06, 007, 008, 009, 010, 020};

        for (var i = 0; i < System.Math.Min(degrees.Length, hours.Length); i++) {
            var a = Angle.Hours(hours[i]);
            Assert.AreEqual(hours[i], (double)a.TotalHours(), 0.0001, $"Incorrectly stored {hours[i]}hrs");
            Assert.AreEqual(degrees[i], (double)a.TotalDegrees(), 0.0001, $"Incorrectly converted {hours[i]}hrs should be {degrees[i]}, but is {a.TotalDegrees()}");
        }
    }
}

}