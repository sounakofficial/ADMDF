using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;

namespace CalcLibrary
{
    [TestFixture]
    public class CalculatorTest
    {
        private Calculator cal;

        [SetUp]
        public void Init()
        {
            cal = new Calculator();
        }

        [Test]
        [TestCase(5, 6, 11)]
        [TestCase(-5, -6, -11)]
        [TestCase(5, -6, -1)]
        public void AdditionTest(int num1, int num2, int expected)
        {
            //Assert.AreEqual(expected, cal.Add(num1, num2));
            Assert.That(expected, Is.EqualTo(cal.Add(num1, num2)));
        }

        [TearDown]
        public void Cleanup()
        {
        }
    }

    [TestFixture]
    internal class CalculatorTest2
    {
        private Calculator cal;

        [SetUp]
        public void Init()
        {
            cal = new Calculator();
        }

        [Test]
        [TestCase(9, 5, 4)]
        [TestCase(-3, 7, -10)]
        [TestCase(-5, -6, 1)]
        public void SubstractionTest(int num1, int num2, int expected)
        {
            Assert.AreEqual(expected, cal.Substract(num1, num2));
        }

        [Test]
        [TestCase(9, 5, 45)]
        [TestCase(-3, 7, -21)]
        [TestCase(-5, -6, 30)]
        public void MultiplicationTest(int num1, int num2, int expected)
        {
            Assert.AreEqual(expected, cal.Multiply(num1, num2));
        }

        [Test]
        [TestCase(35, 7, 5)]
        [TestCase(-20, 4, -5)]
        [TestCase(34, 0, 34)]
        public void DivisionTest(int num1, int num2, int expected)
        {
            try
            {
                Assert.AreEqual(expected, cal.Divison(num1, num2));
            }
            catch (Exception)
            {
                Assert.Fail("Division by zero");
            }
        }

        [Test]
        [TestCase(5, 6, 11)]
        [TestCase(-5, -6, -11)]
        [TestCase(5, -6, -1)]
        public void TestAddAndClear(int num1, int num2, int expected)
        {
            Assert.AreEqual(expected, cal.Add(num1, num2));
            cal.AllClear();
            Assert.AreEqual(0, cal.GetResult);
        }
    }
}