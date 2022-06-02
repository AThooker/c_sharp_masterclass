
using System;

namespace Methods_Functions
{
    internal class Program
    {
        //1. Access modifier   2. return type  3. Method name   4. (parameter list)
        //{
        //    5. Method body
        //}
        
        //1. determined visibility of a variable or a method from another class

        //2. data type to be returned

        //3. Unique id that is case sensitive

        //4. pass and receive data from a ethod

        //5. the instruction for the method to complete
        static void Main(string[] args)
        {
            //WriteSomething();
            //WriteSomethingSpecific("this is the user string");
            //Console.WriteLine(Add(Add(1,6),Add(3, 4)));
            Console.WriteLine(Multiply(25,25));
            Console.WriteLine(Divide(25, 13));
        }

        public static double Divide(double x, double y)
        {
            return x / y;
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static void WriteSomething()
        {
            Console.WriteLine("I am called from a method");
        }
        public static void WriteSomethingSpecific(string userString)
        {
            Console.WriteLine(userString);

        }
    }
}
