using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLibrary;

namespace CalculatorTest
{
    [TestClass]
    public class CalcTest1
    {
        [TestMethod]
        public void SimpleAddition1()
        {
            int start = 1;
            int amount = 1;
            int expected = 2;

            CalcClass Calculator = new CalcClass();

            int actual = Calculator.Add(start, amount);

            Assert.AreEqual(expected, actual, 0.001, "Sum Result Incorrect");
        }

        [TestMethod]
        public void SimpleSubtract1()
        {
            int start = 1;
            int amount = 1;
            int expected = 0;

            CalcClass Calculator = new CalcClass();

            int actual = Calculator.Subtract(start, amount);

            Assert.AreEqual(expected, actual, 0.001, "Sum Result Incorrect");
        }

        [TestMethod]
        public void SimpleAddition2()
        {
            int start = 57;
            int amount = 10000;
            int expected = 10057;

            CalcClass Calculator = new CalcClass();

            int actual = Calculator.Add(start, amount);

            Assert.AreEqual(expected, actual, 0.001, "Sum Result Incorrect");
        }

        [TestMethod]
        public void SimpleSubtraction2()
        {
            int start = 10000;
            int amount = 57;
            int expected = 9943;

            CalcClass Calculator = new CalcClass();

            int actual = Calculator.Subtract(start, amount);

            Assert.AreEqual(expected, actual, 0.001, "Sum Result Incorrect");
        }

        [TestMethod]
        public void negativeAddition1()
        {
            int start = 5;
            int amount = -2;
            int expected = 3;

            CalcClass Calculator = new CalcClass();

            int actual = Calculator.Add(start, amount);

            Assert.AreEqual(expected, actual, 0.001, "Sum Result Incorrect");
        }

        [TestMethod]
        public void negativeSubtraction1()
        {
            int start = 5;
            int amount = -2;
            int expected = 7;

            CalcClass Calculator = new CalcClass();

            int actual = Calculator.Subtract(start, amount);

            Assert.AreEqual(expected, actual, 0.001, "Sum Result Incorrect");
        }

        [TestMethod]
        public void negativeAddition2()
        {
            int start = -100;
            int amount = 15;
            int expected = -85;

            CalcClass Calculator = new CalcClass();

            int actual = Calculator.Add(start, amount);

            Assert.AreEqual(expected, actual, 0.001, "Sum Result Incorrect");
        }

        [TestMethod]
        public void negativeSubtraction2()
        {
            int start = -85;
            int amount = 15;
            int expected = -100;

            CalcClass Calculator = new CalcClass();

            int actual = Calculator.Subtract(start, amount);

            Assert.AreEqual(expected, actual, 0.001, "Sum Result Incorrect");
        }

        [TestMethod]
        public void zreoAddition1()
        {
            int start = 5;
            int amount = 0;
            int expected = 5;

            CalcClass Calculator = new CalcClass();

            int actual = Calculator.Add(start, amount);

            Assert.AreEqual(expected, actual, 0.001, "Sum Result Incorrect");
        }

        [TestMethod]
        public void zeroSubtraction1()
        {
            int start = 5;
            int amount = 0;
            int expected = 5;

            CalcClass Calculator = new CalcClass();

            int actual = Calculator.Subtract(start, amount);

            Assert.AreEqual(expected, actual, 0.001, "Sum Result Incorrect");
        }
    }
}
