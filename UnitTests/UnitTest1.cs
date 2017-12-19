using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PicoYPlacaPredictor.test
{
    [TestClass]
    public class UnitTest1
    {
        CheckClass MyTests = new CheckClass();
        Form1 MyTests2 = new Form1();

        [TestMethod]
        public void NoRestrictionHour()
        {
            bool test = MyTests.performCheck("PBC 8892", 15, 13, "Monday");
            Assert.AreEqual(false, test);
        }

        [TestMethod]
        public void NoRestrictionDay()
        {
            bool test = MyTests.performCheck("PBC 8891", 07, 50, "Friday");
            Assert.AreEqual(false, test);
        }

        [TestMethod]
        public void Restriction()
        {
            bool test = MyTests.performCheck("PBA 8895", 08, 45, "Wednesday");
            Assert.AreEqual(true, test);
        }

        [TestMethod]
        public void WhiteSpacePlate()
        {
            bool test = MyTests.performCheck("PBA 8893    ", 16, 30, "Tuesday");
            Assert.AreEqual(true, test);
        }
        [TestMethod]
        public void EmptyPlate()
        {
            bool test = MyTests2.checkData("");
            Assert.AreEqual(false, test);
        }
    }
}
