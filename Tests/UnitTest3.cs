using System;
using NUnit.Framework;
using HomeWorkTask;

namespace Tests
{
    public class UnitTest3
    {
        [TestCase(1, 1, 1)]
        [TestCase(1, 5, 1)]
        [TestCase(2, 3, 8)]
        public void Task1_WhenNumAndDegreeIsNotZero_ShoudWork(double a, double b, double expectedResult)
        {
            double actualResult = HomeWork3.Task1(a, b);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(0, 0)]
        [TestCase(0, 1)]
        [TestCase(1, 0)]
        public void Task1_WhenNumOrDegreeIsZero_ShoudThrowArgumentException(double a, double b)
        {
            try
            {
                HomeWork3.Task1(a, b);

            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Used 0", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(5, 24)]
        [TestCase(10, 99)]
        public void Task3_WhenNumIsGratherZero_ShouldCalculateFourmula(double a, double expectedResult)
        {
            double actualResult = HomeWork3.Task3(a);
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestCase(0)]
        public void Task3_WhenNumIsZero_ShouldThrowArgumentException(double a)
        {
            try
            {
                HomeWork3.Task3(a);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Number should be greater than zero", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }
    }
}
