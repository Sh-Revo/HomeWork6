using HomeWorkTask;
using NUnit.Framework;
using System;

namespace Tests
{
    public class UnitTest5
    {
        static object[] MinCase = new[]
        {
            new object[] { new[,] { { 10, 3, 9, -2 }, { 5, 2, 8, 3 } }, -2 },
            new object[] { new[,] { { 3, 2 }, { 4, 3 } }, 2 },
        };

        [TestCaseSource(nameof(MinCase))]
        public void MinValue_WhenArrayNotNull_ShouldReturnMinValue(int[,] mas, int expectedMinValue)
        {
            int actualMinValue = HomeWork5.Task1(mas);

            Assert.AreEqual(expectedMinValue, actualMinValue);
        }

        static object[] MaxCase = new[]
        {
            new object[] { new[,] { { 10, 3, 9, -2 }, { 5, 2, 8, 3 } }, 10 },
            new object[] { new[,] { { 3, 2 }, { 4, 3 } }, 4 },
        };

        [TestCaseSource(nameof(MaxCase))]
        public void MaxValue_WhenArrayNotNull_ShouldReturnMaxValue(int[,] mas, int expectedMinValue)
        {
            int actualMinValue = HomeWork5.Task2(mas);

            Assert.AreEqual(expectedMinValue, actualMinValue);
        }

        static object[] MinIndexCase = new[]
        {
            new object[] { new[,] { { 10, 3, 9, -2 }, { 5, 2, 8, 3 } }, 0, 3 },
            new object[] { new[,] { { 3, 2 }, { 4, 3 } }, 0, 1 },
        };

        [TestCaseSource(nameof(MinIndexCase))]
        public void MinIndex_WhenArrayNotNull_ShouldReturnMinIndexValue(int[,] mas, int expectedMinI, int expectedMinJ)
        {
            (int, int) expectedMinIndex = (expectedMinI, expectedMinJ);
            (int, int) actualMinIndex = HomeWork5.Task3(mas);

            Assert.AreEqual(expectedMinIndex, actualMinIndex);
        }

        static object[] MaxIndexCase = new[]
        {
            new object[] { new[,] { { 10, 3, 9, -2 }, { 5, 2, 8, 3 } }, 0, 0 },
            new object[] { new[,] { { 3, 2 }, { 4, 3 } }, 1, 0 },
        };

        [TestCaseSource(nameof(MaxIndexCase))]
        public void MaxIndex_WhenArrayNotNull_ShouldReturnMaxValueIndex(int[,] mas, int expectedMaxI, int expectedMaxJ)
        {
            (int, int) expectedMaxIndex = (expectedMaxI, expectedMaxJ);
            (int, int) actualMaxIndex = HomeWork5.Task4(mas);

            Assert.AreEqual(expectedMaxIndex, actualMaxIndex);
        }

        static object[] ArrayCase = new[]
        {
            new object[] { new[,] { { 10, 8, 5 },
                                   { -3, 9, 12 },
                                   { -10, 1, 8 } },
                          new[,] { { 10, -3, -10 },
                                   { 8, 9, 1 },
                                   { 5, 12, 8 } } },
            new object[] { new[,] { { 14, -14, 1 },
                                   { 20, 2, 5 },
                                   { 3, 1, -1 } },
                          new[,] { { 14, 20, 3 },
                                   { -14, 2, 1 },
                                   { 1, 5, -1 } } }
        };

        [TestCaseSource(nameof(ArrayCase))]
        public void ChangeTheMainDiagonal_WhenArrayNotNull_ShouldReturnArrayChangedTheMainDiagonal(int[,] mas, int[,] expectedArray)
        {
            HomeWork5.Task6(mas);
            Assert.AreEqual(expectedArray, mas);
        }
    }
}
