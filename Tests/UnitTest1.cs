using HomeWorkTask;
using NUnit.Framework;
using System;

namespace Tests
{
    public class Tests
    {
        [TestCase(2, 3, 19)]
        [TestCase(3, 5, 20)]
        public void CalculateEquation_WhenANotEqualToB_ShouldCalculateEquation(
            double a,
            double b,
            double expectedResult)
        {
            double actualResult = HomeWork1.Ex1(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void CalculateEquation_WhenAEqualToB_ShouldThrowArgumentException()
        {
            try
            {
                HomeWork1.Ex1(2, 2);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("A equal to B!", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(1, 4)]
        [TestCase(100, -100)]
        public void ShouldSwap(int a, int b)
        {
            int swapA = a;
            int swapB = b;
            HomeWork1.Swap(ref a, ref b);
            
            Assert.AreEqual(a, swapB);
        }

        [TestCase(5, 2, 2)]
        public void Calculate_WhenAEqualToBForEx3(int a, int b, int expectedResult)
        {
            int actualResult = HomeWork1.Ex3(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(5, 2, 1)]
        public void Calculate_WhenAEqualToBForEx31(int a, int b, int expectedResult)
        {
            int actualResult = HomeWork1.Ex31(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void WhenBIsZero_ShouldThrowArgumentExceptionForEx3()
        {
            try
            {
                HomeWork1.Ex3(2, 0);
            }
            catch (DivideByZeroException ex)
            {
                Assert.AreEqual("B is 0!", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [Test]
        public void WhenBIsZero_ShouldThrowArgumentExceptionForEx31()
        {
            try
            {
                HomeWork1.Ex31(2, 0);
            }
            catch (DivideByZeroException ex)
            {
                Assert.AreEqual("B is 0!", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(2, 2, 6, 2)]
        [TestCase(2, 0, 6, 3)]
        [TestCase(2, 2, 0, -1)]
        public void Calculate_WhenAEqualToBForEx4(int a, int b, int c, int expectedResult)
        {
            double actualResult = HomeWork1.Ex4(a, b, c);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}