using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Qkmaxware.Numbers;

namespace Qkmaxware.Measurement {

[TestClass]
public class BaseMeasureTest {

    [TestMethod]
    public void TestEquality() {
        Length l1 = Length.Metres(10);
        Length l2 = Length.Kilometres(1);
        Length l3 = Length.Metres(10);
        Angle A1 = Angle.Degrees(10);

        Assert.AreEqual(l1, l3);
        Assert.AreNotEqual(l1, l2);
        Assert.AreNotEqual(l1, A1);
    }

}

}