using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Qkmaxware.Numbers;

namespace Qkmaxware.Measurement {

[TestClass]
public class TemperatureTest {
    [TestMethod]
    public void TestKelvin() {
        var t = Temperature.Kelvin(125);
        
        Assert.AreEqual(125, t.TotalKelvin());
    }

    [TestMethod]
    public void TestCelsius() {

    }

    [TestMethod]
    public void TestFahrenheit() {

    }
}

}