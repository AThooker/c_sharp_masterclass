//this gives us access to use classes within the "System" namespace
using System;


namespace HelloWordVS2022
{
    //internal makes this class only accessible from this assembly
    internal class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            //explicit conversion
            double myDouble = 12.34;
            int myInt;
            //cast double to int;
            myInt = (int)myDouble;
            //prints only the whole number since it is now an int - so "12"
            Console.WriteLine(myInt);

            //implicit conversion
            //only from smaller to bigger - a long can convert to a float because it includes all the numbers
            //that come with an int
            int num = 12345;
            long bigNum = num;

            float myFloat = 13.45f;
            double mySecondDouble = myFloat;

            //type conversion
            string myString = mySecondDouble.ToString();
            Console.WriteLine(myString);
            string myFloatString = myFloat.ToString();
            Console.WriteLine(myFloatString);
            bool sunIsShining = true;

            var myBoolString = sunIsShining.ToString();
            Console.WriteLine(myBoolString);

            string myNewString = "15";
            string myNewNewString = "16";
            //Could do try parse, then return value, tryParse returns boolean value
            int num1 = Int32.Parse(myNewString);
            int num2 = Int32.Parse(myNewNewString);
            int result = num1 + num2;
            Console.WriteLine(result);
            //Assignment 1
            float myFloat = float.Parse(stringForFloat);
            int myInt = Int32.Parse(stringForInt);
        }
    }
    //Class name PascalCase
    public class ClientActivity
    {
        //Method name PascalCase
        //Method args in camelCase
        static void CalculateValue(string myArgs)
        {
            //local variable camelCase
            int itemCount;
            //don't use numbers at start of variables
            
        }
    }
}
