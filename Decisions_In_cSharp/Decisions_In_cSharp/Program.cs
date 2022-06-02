using System;

namespace Decisions_In_cSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //string numberAsString = Console.ReadLine();
            //bool success = Int32.TryParse(numberAsString, out int myInt);
            //if(success)
            //{
            //    Console.WriteLine("parsing worked! : " + myInt);
            //}
            //else
            //{
            //    Console.WriteLine("parsing failed");
            //}

            bool isAdmin = false;
            bool isRegistered = true;
            string userName = "";
            Console.WriteLine("Please enter username");
            userName = Console.ReadLine();

            if (isRegistered && userName != "" && userName.Equals("admin"))
            {
                Console.WriteLine("Hi there, registered user");
                Console.WriteLine("Hi there, " + userName);
                Console.WriteLine("Hi there, admin");
            }
            if(isAdmin || isRegistered)
            {
                Console.WriteLine("You are logged in");
            }
        }
    }
}

