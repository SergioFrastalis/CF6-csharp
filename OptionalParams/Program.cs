﻿namespace OptionalParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = GetDateTime();
            Console.WriteLine($"{dateTime:D}");

            DateTime dateTime2 = GetDateTime();
            Console.WriteLine($"{dateTime2:F}");
        }

        public static DateTime GetDateTime(int year = 2024, int month= 11, int day =1 )
        {
            return new DateTime(year, month, day);  
        }
    }
}
