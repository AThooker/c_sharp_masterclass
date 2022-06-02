using System;

namespace Ternary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int temp = -20;
            //string weather = temp < -30 ? "very cold" : "probably still cold but warmer";
            //Console.WriteLine(weather);
            //weather = temp > 100 ? "hot" : temp < 0 ? "colder" : "warmer"; 
            Console.WriteLine("Enter the current temperature as an integer: ");
            bool isNumber = int.TryParse(Console.ReadLine(), out int temp);
            if(isNumber)
            {
                TemperatureCheck(temp);
            }
            else
            {
                Console.WriteLine("Not a valid temp ya dingus");
            }
        }
        public static void TemperatureCheck(int temp)
        {
            string result = temp <= 15 ? "it is too cold here" : temp >= 16 && temp <= 28 ? "it is ok" : "it is hot here";
            Console.WriteLine(result);
        }
    }
}
