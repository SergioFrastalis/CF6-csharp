using System.Data;

namespace SwapApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 10;
            //int b = 20;
            //Swap(a, b);
            //Console.WriteLine($"a: {a}, b: {b}");

            string s = "Hello";
            changeStr(s);
            Console.WriteLine(s);

        }

        public static void Swap( int a, int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        public static void Swap(ref int a, ref int b)
        {
            (a, b) = (b, a);
        }

        public static void changeStr(string str)
        {
            str = "AUEB";
        }
    }
}
