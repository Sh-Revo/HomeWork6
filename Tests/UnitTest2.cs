using System;
using NUnit.Framework;
using HomeWorkTask;

namespace Tests
{
    public class Tests1
    {
        [TestCase(5, 3, 8)]
        [TestCase(6, 6, 36)]
        [TestCase(6, 10, -4)]
        public void CalculateFormula_ShouldCalculateFormula(double a, double b, double expectedResult)
        {
            double actualResult = HomeWork2.Task1(a, b);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(11, 8, 1)]
        [TestCase(-1, -2, 3)]
        [TestCase(-5, 9, 2)]
        [TestCase(10, -1, 4)]
        public void Task2_WhenXOrYIsNotZero_ShouldPointCoordinates(double x, double y, int expectedResult)
        {
            int actualResult = HomeWork2.Task2(x, y);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(0, 0)]
        public void Task2_WhenXOrYIsZero_ShouldThrowArgumentException(double x, double y)
        {
            try
            {
                HomeWork2.Task2(x, y);
            }

            catch (ArgumentException ex)
            {
                Assert.AreEqual("Сoordinates is (0;0) and dont belongs to axis", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }
    }
}
