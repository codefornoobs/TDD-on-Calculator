using System.Security.Cryptography.X509Certificates;

namespace Calculator
{
    public class Calculate
    {
        public static int Sum(int x, int y)
        {
            return x + y;
        }

        public static int Mult(int i, int i1)
        {
            return i * i1;
        }

        public static int Div(int i, int i1)
        {
            return i / i1;
        }

        public static int Sub(int i, int i1)
        {
            return i - i1;
        }
    }
}
