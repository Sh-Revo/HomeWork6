using System;

namespace HomeWorkTask
{
    public class HomeWork1
    {
        public static double Ex1(double a, double b)
        {
            if(a == b)
            {
                throw new ArgumentException("A equal to B!");
            }
            return (5 * a + b * b) / (b - a);
        }

        public static void Swap(ref int a, ref int b)
        {
            if (a != null && b != null)
            {
                int temp = a;
                a = b;
                b = temp;
            }
            else
            {
                throw new ArgumentNullException("Variable/s is/are null");
            }
        }

        public static int Ex3(int a, int b)
        {
            if (a == 0)
            {
                throw new NullReferenceException("Zero is not allowed as integer");
            }
            if (b == 0)
            {
                throw new DivideByZeroException("B is 0!");
            }

            return a / b;
        }

        public static int Ex31(int a, int b)
        {
            if (a == 0)
            {
                throw new NullReferenceException("Zero is not allowed as integer");
            }
            if (b == 0)
            {
                throw new DivideByZeroException("B is 0!");
            }

            return a % b;
        }

        public static double Ex4(int a, int b, int c)
        {
            if (a == 0)
            {
                throw new DivideByZeroException();
            }
            if (c - b == 0)
            {
                throw new NullReferenceException("Zero is not allowed as integer");
            }

            return Math.Round((double)(c - b) / a, 2);
        }

        public static (double, double) Ex5(int x1, int x2, int y1, int y2)
        {
            if (x1 == x2 && y1 == y2)
            {
                throw new ArgumentException("points have the same coordinates");
            }
            if (x2 - 11 == 0)
            {
                throw new DivideByZeroException();
            }

            return ((y2 - y1) / (x2 - x1), -(x1 * y2 - x2 * y1) / (x2 - x1));
        }


    }
}
