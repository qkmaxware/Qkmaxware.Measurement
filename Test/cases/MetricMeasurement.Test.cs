using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Qkmaxware.Numbers;

namespace Qkmaxware.Measurement {

[TestClass]
public class MetricMeasurementTest {

    /// <summary>
    /// Test class exposing the valueAs protected method for testing purposes
    /// </summary>
    private class TestMeasure : MetricMeasurement {
        public override Unit UnitsOfMeasure => null;
        public TestMeasure(Scientific value, MetricPrefix prefix) : base(value, prefix) {}
        public Scientific GetValueAs(MetricPrefix prefix) => this.ValueAs(prefix);
    }

    [TestMethod]
    public void TestNonePrefix() {
        var measure = new TestMeasure(new Scientific(10_000, 0), MetricPrefix.None);
        
        Assert.AreEqual(10_000, measure.GetValueAs(MetricPrefix.None));
        Assert.AreEqual(10, measure.GetValueAs(MetricPrefix.Kilo));
        Assert.AreEqual(10000000, measure.GetValueAs(MetricPrefix.Milli));
    }

    [TestMethod]
    public void TestKiloPrefix() {
        var measure = new TestMeasure(new Scientific(10, 0), MetricPrefix.Kilo);
        
        Assert.AreEqual(10_000, measure.GetValueAs(MetricPrefix.None));
        Assert.AreEqual(10, measure.GetValueAs(MetricPrefix.Kilo));
        Assert.AreEqual(10000000, measure.GetValueAs(MetricPrefix.Milli));
    }

}

}