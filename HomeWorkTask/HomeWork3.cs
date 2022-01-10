using System;

namespace HomeWorkTask
{
    public class HomeWork3
    {
        public static double Task1(double a, double b)
        {
            double result = 1;

            if (a == 0 || b == 0)
            {
                throw new ArgumentException("Used 0");
            }
            for (int i = 0; i < b; i++)
            {
                result *= a;
            }

            return result;
        }

        public static int Task3(double a)
        {
            double b = 0;
            int count = 0;

            if (a == 0)
            {
                throw new ArgumentException("Number should be greater than zero");
            }
            b = a * a;
            for (int i = 0; i < b - 1; i++)
            {
                if (a > 0)
                {
                    count++;
                }
                else if (a < 0)
                {
                    a = Math.Abs(a);
                    count++;
                }
            }

            return count;
        }

        public static int Task4(int a)
        {
            int divider = 0;

            if (a < 1)
            {
                throw new ArgumentException("Number should be greater than zero");
            }
            for (int i = 1; i < a; i++)
            {
                if (a % i == 0)
                {
                    divider = i;
                }
            }

            return divider;
        }

        public static double Task5(double a, double b)
        {
            double sum = 0;

            if (a == b)
            {
                throw new ArgumentException("Numbers are the same");
            }
            if (a < b)
            {
                for (double i = a + 1; i > a && i < b; i++)
                {
                    if (i % 7 == 0)
                    {
                        sum = sum + i;
                    }
                }
            }
            else if (b < a)
            {
                for (double i = b + 1; i > b && i < a; i++)
                {
                    if (i % 7 == 0)
                    {
                        sum = sum + i;
                    }
                }
            }

            return sum;
        }

        public static int fib(int n)
        {
            if (n < 1)
            {
                throw new ArgumentException("Number should be greater than zero");
            }

            return n > 1 ? fib(n - 1) + fib(n - 2) : n;
        }

        public static int GRD(int a, int b)
        {
            if (b < 1)
            {
                throw new ArgumentException("Number should be greater than zero");
            }
            while (b != 0)
            {
                var t = b;
                b = a % b;
                a = t;
            }

            return a;
        }

        public static int Task9(int number)
        {
            int result = 0;

            if (number < 1)
            {
                throw new ArgumentException("Number should be greater than zero");
            }
            for (int i = 0; i < number; i++)
            {
                if (i % 2 == 1)
                {
                    result += 1;
                }
            }

            return result;
        }

        public static int Task10(int number)
        {
            int result = 0;

            if (number == 0)
            {
                throw new ArgumentException("Number should be zero");
            }
            while (number != 0)
            {
                int current = number % 10;
                number /= 10;
                result *= 10;
                result += current;
            }

            return result;
        }

        public static bool Task12(int a, int b)
        {
            int numb1, numb2;
            bool flag = false;
            int valueB;

            if (a < 1 || b < 1)
            {
                throw new ArgumentException("Numbers should be greater than zero");
            }
            while (a != 0)
            {
                numb1 = a % 10;
                a /= 10;
                valueB = b;
                while (valueB != 0)
                {
                    numb2 = valueB % 10;
                    valueB /= 10;
                    if (numb1 == numb2)
                    {
                        flag = true;
                    }
                }
            }

            return flag;
        }
    }
}
