using System;

namespace Params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ParamsMethod("This", "is", "my", "test", "params", "sentence");
            //ParamsMethod("This", "is", "my", "test", "params", "sentence", "again");
            //ParamsMethod();
            //int price = 50;
            //float pi = 3.14f;
            //char at = '@';
            //string book = "The Hobbit";
            //ParamsMethod2(price, pi, at, book);
            //ParamsMethod2("Hello", 5.3, 'O');
            int min = MinV2(6, 7, 8, 2, 0, -100, -2);
            Console.WriteLine($"The minimum is: {min}");
            
        }
        //params lets you take in a varying number of args
        public static void ParamsMethod(params string[] sentence)
        {
            for(int i = 0; i < sentence.Length; i++)
            {
                Console.Write(sentence[i] + " ");
            }
            Console.WriteLine();
        }
        public static void ParamsMethod2(params object[] stuff)
        {
            //for each loop to go through the array of objects
            foreach(object obj in stuff)
            {
                //print each object followed by space
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
        public static int MinV2(params int[] numbers)
        {
            int min = int.MaxValue;
            foreach(var number in numbers)
            {
                if(number < min)
                {
                    min = number;
                }
            }
            return min;
        }

    }
}
