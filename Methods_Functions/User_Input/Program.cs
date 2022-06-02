using System;

namespace User_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculate();
            //UserInputTryCatchMethod();
            DivideByZeroForExceptionHandling(5);
        }
        public static void Calculate()
        {
            Console.WriteLine("Please give me a number to add to itself");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine($"I have added {input} and {input} to make {input + input}!");
        }
        public static void UserInputTryCatchMethod()
        {
            Console.WriteLine("Please enter a number");
            try
            {
                int userInput = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception, please enter the correct type next time");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception, your number was too large or too small");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Value was null");
            }
            finally
            {
                Console.WriteLine("I will always be called regardless of try or catch processing successfully");
            }
            Console.ReadKey();
        }
        public static void DivideByZeroForExceptionHandling(int x)
        {
            try
            {
               int dividedNum =  x / 0;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide a number by zero dingus");
            }
        }
    }
}
