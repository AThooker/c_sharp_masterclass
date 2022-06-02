using System;

namespace Decisions_Challenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoginSystem();
        }
        public static void LoginSystem()
        {
            //require user to register then login using the same registration info

            //use if statements to assess register vs login info
            Console.Write("Please register a Username and Password for your account!\n" +
                "\nUsername: ");
            string username = Console.ReadLine();
            Console.Write("\nPassword: ");
            string password = Console.ReadLine();
            Console.Clear();
            Console.Write("Now please login with the credentials you just typed in\n" +
                "Username: ");
            string userLogin = Console.ReadLine();
            Console.Write("\nPassword: ");
            string passwordLogin = Console.ReadLine();
            if(userLogin != username)
            {
                Console.WriteLine("Incorrect username");
            }
            else if(password != passwordLogin)
            {
                Console.WriteLine("Incorrect password");
            }
            else if(username != userLogin && password != passwordLogin)
            {
                Console.WriteLine("Incorrect credentials");
            }
            else
            {
                Console.WriteLine("You're in!");
            }
        }
    }
}
