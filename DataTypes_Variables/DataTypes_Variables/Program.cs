using System;

namespace DataTypes_Variables
{
    internal class Program
    {
        //Constants - immutable values which are known at compile time and do not change for life of program
        const double PI = 3.14159;
        const int weeks = 52, months = 12;
        const string birthday = "12/30/1995";
        static void Main(string[] args)
        {
            Console.WriteLine($"My birthday is always going to be {birthday}");
            //string manipulation
            int age = 26;
            string name = "Austin";
            // 1. Concatenation
            Console.WriteLine("Hello my name is " + name + " , I am " + age + " years old");

            // 2. Formatting
            Console.WriteLine("Hello my name is {0} , I am {1} years old", name, age);
            Console.WriteLine("Hello World!");

            // 3. Interpolation
            Console.WriteLine($"Hello my name is {name}, I am {age} years old");

            // 4. Verbatim string
            // start with a @ and tells compiler to take everything in the string

            Console.WriteLine(@"C:/filepath/myfile/");

        }

    }
}
