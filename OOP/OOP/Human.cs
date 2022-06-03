using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    // blueprint for dataType "Human"
    internal class Human
    {
        //member variable
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;
        //member method
        public void IntroduceName()
        {
            if (age < 2)
            {
                Console.WriteLine("I am still to young to introduce myself you fool");
            }
            else
            {
                Console.WriteLine($"Hi my name is {firstName} {lastName}\n" +
                    $"I have {eyeColor} eyes.");
            }
        }
        //"this" refers to current instance of class, also distinguished the member variables from the paramters
        public Human()
        {
            Console.WriteLine("New Human created, default ctor");
        }
        public Human(string firstName)
        {
            this.firstName = firstName;
        }
        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public Human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }
    }
}
