using System;

namespace Interface
{
    class Weapon
    {
        public string name;
        public void Label()
        {
            Console.WriteLine($"This is {name}");
        }
    }
}
