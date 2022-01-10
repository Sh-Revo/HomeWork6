using HomeWorkTask;
using NUnit.Framework;
using System;

namespace Tests
{
    public class UnitTest4
    {
        [TestCase(new int[] { 6, 10, -1, -11, 0, -3, 15 }, -11)]
        public void GetMinNumInArray_ShouldReturnMinNumInArr(int[] mas, int expectedResult)
        {
            int actualResult = HomeWork4.Task1(mas);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(null)]
        [TestCase(new int[] { })]
        public void GetMinNumInArray_WhenArrIsNull_ShouldThrowArgumentNullException(int[] mas)
        {
            try
            {
                int actualResult = HomeWork4.Task1(mas);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Array is empty", ex.ParamName);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(new int[] { 6, 10, -1, -11, 0, -3, 15 }, 3)]
        [TestCase(new int[] { 1 }, 0)]
        public void GetMinIndexInArray_ShouldReturnIndexMinInArr(int[] mas, int expectedResult)
        {
            int actualResult = HomeWork4.Task3(mas);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(null)]
        [TestCase(new int[] { })]
        public void GetMinIndexInArray_WhenArrIsNull_ShouldThrowArgumentNullException(int[] mas)
        {
            try
            {
                int actualResult = HomeWork4.Task3(mas);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Array is empty", ex.ParamName);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(new int[] { 1, 10, -5, 0, 2, -11, 6 }, 4)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 9)]
        [TestCase(new int[] { 1 }, 1)]
        public void SummOfItems_ShouldCalculate(int[] mas, int expectedResult)
        {
            int actualResult = HomeWork4.Task5(mas);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(null)]
        [TestCase(new int[] { })]
        public void SumOfItems_WhenArrIsNull_ShouldThrowArgumentNullException(int[] mas)
        {
            try
            {
                HomeWork4.Task5(mas);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Array is empty", ex.ParamName);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(new int[] { 10, 5, 3, -1, 0, 13, 2 }, new int[] { 2, 13, 0, -1, 3, 5, 10 })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        public void ReverseArray_ShouldReverseArray(int[] mas, int[] expectedResult)
        {
            HomeWork4.Task6(mas);
            Assert.AreEqual(expectedResult, mas);
        }

        [TestCase(null)]
        [TestCase(new int[] { })]
        public void ReverseArray_WhenArrIsNull_ShouldThrowArgumentNullException(int[] mas)
        {
            try
            {
                HomeWork4.Task6(mas);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Array is empty", ex.ParamName);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(new int[] { 1, 10, -5, 0, 2, -11, 6 }, 3)]
        [TestCase(new int[] { 0 }, 0)]
        public void ElementsCount_ShouldCountElements(int[] mas, int expectedResult)
        {
            int actualResult = HomeWork4.Task7(mas);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(null)]
        [TestCase(new int[] { })]
        public void EleementsCount_WhenArrIsNull_ShouldThrowArgumentNullException(int[] mas)
        {
            try
            {
                HomeWork4.Task7(mas);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Array is empty", ex.ParamName);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(new int[] { 10, 5, 3, -1, 0, 13, 2 }, new int[] { -1, 0, 13, 10, 5, 3, 2 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 3, 4, 1, 2 })]
        [TestCase(new int[] { 0 }, new int[] { 0 })]
        public void ReverseArr_ShouldReverseArr(int[] mas, int[] expectedResult)
        {
            HomeWork4.Task8(mas);
            Assert.AreEqual(expectedResult, mas);
        }

        [TestCase(null)]
        [TestCase(new int[] { })]
        public void ReverseArr_WhenArrIsNull_ShouldThrowArgumentNullException(int[] mas)
        {
            try
            {
                HomeWork4.Task8(mas);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Array is empty", ex.ParamName);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(new int[] { 10, 5, 3, -1, 0, 13, 2 }, new int[] { -1, 0, 2, 3, 5, 10, 13 })]
        [TestCase(new int[] { 0 }, new int[] { 0 })]
        public void SelectionSort_ShouldSorrtByImcrease(int[] mas, int[] expectedResult)
        {
            HomeWork4.Task9(mas);
            Assert.AreEqual(expectedResult, mas);
        }

        [TestCase(null)]
        [TestCase(new int[] { })]
        public void SelectionSort_WhenArrIsNull_ShouldThrowArgumentNullException(int[] mas)
        {
            try
            {
                HomeWork4.Task9(mas);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Array is empty", ex.ParamName);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(new int[] { 10, 5, 3, -1, 0, 13, 2 }, new int[] { 13, 10, 5, 3, 2, 0, -1 })]
        [TestCase(new int[] { 0 }, new int[] { 0 })]
        public void AnotherSortReverse_ShouldSort(int[] mas, int[] expectedResult)
        {
            HomeWork4.Task10(mas);
            Assert.AreEqual(expectedResult, mas);
        }

        [TestCase(null)]
        [TestCase(new int[] { })]
        public void AnotherSortReverse_WhenArrIsNull_ShouldThrowArgumentNullException(int[] mas)
        {
            try
            {
                HomeWork4.Task10(mas);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Array is empty", ex.ParamName);
                Assert.Pass();
            }

            Assert.Fail();
        }
    }
}
