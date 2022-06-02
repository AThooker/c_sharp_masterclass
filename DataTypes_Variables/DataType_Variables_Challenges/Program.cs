using System;
using System.Linq;

namespace DataType_Variables_Challenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ChallengeStringsOne();
            //ChallengeStringsTwo();
            ChallengeDataTypes();

        }
        static  void ChallengeStringsOne()
        {
            string varOne;
            Console.WriteLine("Please enter your name and press enter");
            varOne = Console.ReadLine();
            Console.WriteLine(varOne.ToUpper());
            Console.WriteLine(varOne.ToLower());
            Console.WriteLine(varOne.Trim());
            Console.WriteLine(varOne.Substring(3));
            Console.WriteLine(string.Concat(varOne.Where(c => !Char.IsWhiteSpace(c))));
        }
        static void ChallengeStringsTwo()
        {
            Console.WriteLine("Enter a string here: ");
            string varTwo = Console.ReadLine();
            Console.WriteLine("Enter the character you'd like me to search: ");
            char letter = Console.ReadLine()[0];
            Console.WriteLine(varTwo.IndexOf(letter));

            Console.WriteLine("Please enter a first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter a last name");
            string lastName = Console.ReadLine();
            string fullName = string.Concat(firstName," ",lastName);
            Console.WriteLine($"Full name: {fullName}");

        }

        static void ChallengeDataTypes()
        {
            byte byteVar = 3;
            sbyte sbyteVar = 126;
            int intVar = 300;
            short shortVar = 25000;
            long longVar = 2344564;
            float floatVar = 34.566f;
            double doubleVar = 2.354454545;
            decimal decimalVar = 34.6765644556466m;
            char charVar = 'a';
            bool boolVar = false;
            string stringVarOne = "I control text";
            string stringVarTwo = "24";
            int stringToInt = Int32.Parse(stringVarTwo);
            Console.WriteLine(stringToInt.GetType().ToString());
        }
    }
}
