using System;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 10;
            int num3;

            //unary operators
            num3 = -num1;
            Console.WriteLine(num3);

            bool isSunny = true;
            Console.WriteLine(!isSunny);

            //increment operators
            int num = 0;
            num++;
            Console.WriteLine(num);
            Console.WriteLine(num++); //num will only increase for the next line when num++
            //pre increment
            Console.WriteLine(++num); // num will increase for same line when ++num

            //decrement operators
            num--;
            Console.WriteLine(num);
            Console.WriteLine(num--);
            //pre decrement
            Console.WriteLine(--num);

            //relational and type operators
            bool isLower;
            isLower = num1 < num2;
            Console.WriteLine(isLower);

            //equality operator
            bool isEqual;
            isEqual = num1 == num2;
            Console.WriteLine(isEqual);

            isEqual = num1 != num2;
            Console.WriteLine(isEqual);

            //conditional operator

            //AND
            bool isLowerAndSunny;
            isLowerAndSunny = isLower && isEqual;
            Console.WriteLine(isLowerAndSunny);
            //OR
            isLowerAndSunny = isLower || isSunny;
            Console.WriteLine(isLowerAndSunny);
        }
    }
}
