using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void maxInEnd()
        {
            var message = Logic.FindMaxDigit(879);

            Assert.AreEqual("Наибольшее 9", message);
        }

        [TestMethod()]
        public void maxInMiddle()
        {
            var message = Logic.FindMaxDigit(672);

            Assert.AreEqual("Наибольшее 7", message);
        }

        [TestMethod()]
        public void maxInStart()
        {
            var message = Logic.FindMaxDigit(345);

            Assert.AreEqual("Наибольшее 5", message);
        }

        [TestMethod()]
        public void twoMaxNumbers()
        {
            var message = Logic.FindMaxDigit(992);

            Assert.AreEqual("Наибольшее 9", message);
        }
        [TestMethod()]
        public void allNumbersMax()
        {
            var message = Logic.FindMaxDigit(777);

            Assert.AreEqual("Наибольшее 7", message);
        }
    }
}