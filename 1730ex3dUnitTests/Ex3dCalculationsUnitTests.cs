using System;
using _1730ex3d;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _1730ex3dUnitTests
{
    [TestClass]
    public class Ex3dCalculationsUnitTests
    {
        [TestMethod]
        public void ArrayToString_Test()
        {
            string expected = "300, 500, 200, 150, 600, 750, 900, 150, 100, 200, 250, 650, 300, 750, 800, 350, 250";
            int[] values = {300, 500, 200, 150, 600, 750, 900, 150,
                100, 200, 250, 650, 300, 750, 800, 350, 250};
            Assert.AreEqual(expected, Ex3dCalculations.ArrayToString(values));
        }

        [TestMethod]
        public void ValueCount_Test()
        {
            int[] values = {300, 500, 200, 150, 600, 750, 900, 150,
                100, 200, 250, 650, 300, 750, 800, 350, 250};
            Assert.AreEqual(2, Ex3dCalculations.ValueCount(values, 300));
        }

        [TestMethod]
        public void RangeCount_Test()
        {
            int[] values = {300, 500, 200, 150, 600, 750, 900, 150,
                100, 200, 250, 650, 300, 750, 800, 350, 250};
            Assert.AreEqual(9, Ex3dCalculations.RangeCount(values, 100, 300));
        }
    }
}
