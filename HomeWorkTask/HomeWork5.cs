using System;

namespace HomeWorkTask
{
    public class HomeWork5
    {
        public static int Task1(int[,] mas)
        {
            int min = mas[0, 0];

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (mas[i, j] < min)
                    {
                        min = mas[i, j];
                    }
                }
            }

            return min;
        }

        public static int Task2(int[,] mas)
        {
            int max = mas[0, 0];

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (mas[i, j] > max)
                    {
                        max = mas[i, j];
                    }
                }
            }

            return max;
        }

        public static (int, int) Task3(int[,] mas)
        {
            (int, int) indexMin = (0, 0);
            int min = mas[0, 0];

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (mas[i, j] < min)
                    {
                        min = mas[i, j];
                        indexMin = (i, j);
                    }
                }
            }

            return indexMin;
        }

        public static (int, int) Task4(int[,] mas)
        {
            (int, int) indexMax = (0, 0);
            int max = mas[0, 0];

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (mas[i, j] > max)
                    {
                        max = mas[i, j];
                        indexMax = (i, j);
                    }
                }
            }

            return indexMax;
        }

        public static int[,] Task6(int[,] mas)
        {
            int t;

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < i; j++)
                {
                    t = mas[i, j];
                    mas[i, j] = mas[j, i];
                    mas[j, i] = t;
                }
            }

            return mas;
        }

        //antidiagonal
        public static int[,] Task7(int[,] mas)
        {
            int t;

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < (mas.GetLength(0) - 1) - i; j++)
                {
                    t = mas[i, j];
                    mas[i, j] = mas[mas.GetLength(0) - 1 - j, mas.GetLength(0) - 1 - i];
                    mas[mas.GetLength(0) - 1 - j, mas.GetLength(0) - 1 - i] = t;
                }
            }

            return mas;
        }
    }
}
