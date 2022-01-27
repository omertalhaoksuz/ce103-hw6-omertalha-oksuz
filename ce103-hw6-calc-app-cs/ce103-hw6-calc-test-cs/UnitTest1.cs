using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LesGraphingCalc;

namespace ce103_hw6_calc_test_cs
{
    [TestClass]
    public class UnitTest1
    {
        public void CalculateTest1()
        {
            var expected = RPN.Calculate("72 + 28");
            var actual = 100;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest2()
        {
            var expected = RPN.Calculate("50 - 40");
            var actual = 10;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void CalculateTest3()
        {
            var expected = RPN.Calculate("sqrt(9");
            var actual = 3;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest4()
        {
            var expected = RPN.Calculate("ln(e^5");
            var actual = 5;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest5()
        {
            var expected = RPN.Calculate("lg(1000");
            var actual = 3;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest6()
        {
            var expected = RPN.Calculate(" %10");
            var actual = 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest7()
        {
            var expected = RPN.Calculate(" !5");
            var actual = 120;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest8()
        {
            var expected = RPN.Calculate(" 10 * 10");
            var actual = 100;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest9()
        {
            var expected = RPN.Calculate(" 75 / 5");
            var actual = 15;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest10()
        {
            var expected = RPN.Calculate(" 1^9");
            var actual = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest11()
        {
            var expected = RPN.Calculate(" 2^3");
            var actual = 8;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest12()
        {
            var expected = RPN.Calculate(" 0^y");
            var actual = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest13()
        {
            var expected = RPN.Calculate("(1/100");
            var actual = 0.01;
            Assert.AreEqual(expected, actual);
        }
    }
}
