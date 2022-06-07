using System;

namespace VirtualAndOverride
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Spot", 6);
            Console.WriteLine($"{dog.Name} is {dog.Age} years old");
        }
    }
}
