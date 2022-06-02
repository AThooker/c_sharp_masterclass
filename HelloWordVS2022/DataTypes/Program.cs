using System;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();

            //NUMBERS

            //-128 - 127
            sbyte b = 2;
            Console.WriteLine(b);

            //-32K - 32K
            short c = 3;

            //- 2 million - + 2 million
            int a = 1;

            //-9 billion/billion - 9 billion billion
            long d = 4;

            //decimals with 7-digit precision
            float f = 5f;

            //higher range than float with 15-digit precision
            double g = 6;

            //higher range and 28-digit precision
            decimal h = 7;

            /* float is mostly for graphics libraries (hpc)
             * double is mostly for real world values
             * decimals is used for financial applications (highest accuracy)
             */

            int i = 8;
            int sum = i + a;
            Console.WriteLine(sum);
            //concatenation
            Console.WriteLine("num1: " + a + " num2: " + i + " sum: " + sum);
            //interpolation
            Console.WriteLine($"num1: {a} num2: {i} sum: {sum}");

            //STRINGS

            string myName = "Austin";
            string message = $"my name is {myName}";
            //using string built-in methods
            string upperMessage = myName.ToUpper();
            Console.WriteLine("My name is " + myName);
            Console.WriteLine(message);
            Console.WriteLine(upperMessage);
            string lowerCase = myName.ToLower();
            Console.WriteLine(lowerCase);
            Console.WriteLine("Hello world");
            Console.Write("Hello");
            Console.Write("World");
            Console.ReadKey();

            Console.WriteLine("enter a string and press enter");
            int asciiVal = Console.Read();
            Console.WriteLine($"ASCII value is {asciiVal}");
            Console.ReadKey();
            
        }
    }
}
