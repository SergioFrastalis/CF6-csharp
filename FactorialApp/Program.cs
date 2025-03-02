﻿using System.Numerics;

namespace FactorialApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 20; i++) 
            {
                Console.WriteLine($"{i, 3}! = {FactoIterative(i),30:N0}");
            }
        }

        public static BigInteger FactoIterative(int n)
        {
            BigInteger result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        public static BigInteger FactoRecursive(int n)
        {
            return (n > 1) ? n * FactoRecursive(n - 1) : 1;
        }
    }
}
