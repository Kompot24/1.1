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
        public void firstTest()
        {
            int numb = 879;

            var message = Logic.Compare(numb);

            Assert.AreEqual("Наибольшее 9", message);
        }

        [TestMethod()]
        public void secondTest()
        {
            int numb = 672;

            var message = Logic.Compare(numb);

            Assert.AreEqual("Наибольшее 7", message);
        }

        [TestMethod()]
        public void thirdTest()
        {
            int numb = 345;

            var message = Logic.Compare(numb);

            Assert.AreEqual("Наибольшее 5", message);
        }
    }
}