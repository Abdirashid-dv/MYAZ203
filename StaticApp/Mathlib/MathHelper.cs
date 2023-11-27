namespace Mathlib
{
    public static class MathHelper
    {
        static MathHelper()
        {

        }
        public static int Add(int a, int b) => a + b;
        public static int Division(int a, int b) { 
            if (b == 0)
            {
                throw new DivideByZeroException("You Tried To Divided Zero");
            }
            else
            {
                return a / b;
            }
        }
        public static int Multiplication(int a, int b) => a * b;
        public static int Substract(int a, int b) => a - b;
    }
}