using System;

namespace Methods_ChallengeOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string friendOne = "bryce";
            //string friendTwo = "luke";
            //string friendThree = "logan";
            //GreetFriend(friendOne);
            //GreetFriend(friendTwo);
            //GreetFriend(friendThree);
            Console.WriteLine(LowUpper("test"));
            Count("test");
        }


        public static void GreetFriend(string friend)
        {
            Console.WriteLine($"Hi {friend}, my friend!");
        }
        public static string LowUpper(string text)
        {
            return String.Concat(text.ToLower(), text.ToUpper());
        }

        public static void Count(string text)
        {
            Console.WriteLine($"The amount of letters is {text.Length}");
        }
    }
}
