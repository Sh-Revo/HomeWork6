using System;

namespace HomeWorkTask
{
    public class HomeWork4
    {
        public static int Task1(int[] mas)
        {
            if (mas == null || mas.Length == 0)
            {
                throw new ArgumentNullException("Array is empty");
            }
            int min = mas[0];
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] < min)
                {
                    min = mas[i];
                }
            }

            return min;
        }

        public static int Task2(int[] mas)
        {
            int max = mas[0];

            if (mas == null || mas.Length == 0)
            {
                throw new ArgumentNullException("Array is empty");
            }
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] > max)
                {
                    max = mas[i];
                }
            }

            return max;
        }

        public static int Task3(int[] mas)
        {
            if (mas == null || mas.Length == 0)
            {
                throw new ArgumentNullException("Array is empty");
            }
            int min = mas[0];
            int indexMin = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] < min)
                {
                    min = mas[i];
                    indexMin = i;
                }
            }

            return indexMin;
        }

        public static int Task4(int[] mas)
        {
            if (mas == null || mas.Length == 0)
            {
                throw new ArgumentNullException("Array is empty");
            }
            int max = mas[0];
            int indexMax = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] < max)
                {
                    max = mas[i];
                    indexMax = i;
                }
            }

            return indexMax;
        }

        public static int Task5(int[] mas)
        {
            int sum = 0;

            if (mas == null || mas.Length == 0)
            {
                throw new ArgumentNullException("Array is empty");
            }
            for (int i = 0; i < mas.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sum += mas[i];
                }
            }

            return sum;
        }

        public static void Task6(int[] mas)
        {
            if (mas == null || mas.Length == 0)
            {
                throw new ArgumentNullException("Array is empty");
            }
            int i = 0;
            int j = mas.Length - 1;
            while (i < j)
            {
                int tmp = mas[i];
                mas[i] = mas[j];
                mas[j] = tmp;
                i++;
                j--;
            }
        }

        public static int Task7(int[] mas)
        {
            int count = 0;

            if (mas == null || mas.Length == 0)
            {
                throw new ArgumentNullException("Array is empty");
            }
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] % 2 != 0)
                {
                    count++;
                }
            }

            return count;
        }

        public static void Task8(int[] mas)
        {
            if (mas == null || mas.Length == 0)
            {
                throw new ArgumentNullException("Array is empty");
            }
            int i = 0;
            int j = mas.Length / 2;
            while (i < mas.Length / 2)
            {
                int tmp = mas[i];
                mas[i] = mas[j];
                mas[j] = tmp;
                i++;
                j++;
            }
        }

        public static void Swap(ref int i, ref int j)
        {
            int t = i;
            i = j;
            i = t;
        }

        public static void Task9(int[] mas)
        {
            int min, temp;

            if (mas == null || mas.Length == 0)
            {
                throw new ArgumentNullException("Array is empty");
            }
            for (int i = 0; i < mas.Length - 1; i++)
            {
                min = i;

                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[j] < mas[min])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    temp = mas[i];
                    mas[i] = mas[min];
                    mas[min] = temp;
                }
            }
        }

        public static void Task10(int[] mas)
        {
            if (mas == null || mas.Length == 0)
            {
                throw new ArgumentNullException("Array is empty");
            }
            for (int i = 0; i < mas.Length; i++)
            {
                int current = mas[i];
                int j = i;
                while (j > 0 && current > mas[j - 1])
                {
                    mas[j] = mas[j - 1];
                    j--;
                }
                mas[j] = current;
            }
        }
    }
}
