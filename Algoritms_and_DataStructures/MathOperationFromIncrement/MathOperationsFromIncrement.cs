using System;

namespace Algoritms_and_DataStructures.MathOperationFromIncrement
{
    public static class MathOperationsFromIncrement
    {
        public static int Substraction(int a, int b)
        {
            if (b == 0)
                return a;
            if (a == 0)
                return -b;
            int counter = 0;
            int result = 0;
            if (a < b)
            {
                return -Substraction(b, a);
            }
            while (counter < a)
            {
                if (counter >= b)
                {
                    result++;
                }
                counter++;
            }
            return result;
        }

        public static int Multiplication(int a, int b)
        {
            if (a == 0 || b == 0)
                return 0;

            int result = 0;
            int counterB = 0;
            int counterA = 0;

            if (a < 0 || b < 0)
            {
                int A = Math.Abs(a);
                int B = Math.Abs(b);
                return -Multiplication(A, B);
            }
            while (counterB < b)
            {
                while (counterA < a)
                {
                    result++;
                    counterA++;
                }
                counterA = 0;
                counterB++;
            }
            return result;
        }

        public static int Division(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Деление на ноль!");
            }

            if (a == 0)
                return 0;

            int result = 0;
            for (int i = 1; ; i++)
            {
                if (Multiplication(i, b) == a)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }
    }
}
