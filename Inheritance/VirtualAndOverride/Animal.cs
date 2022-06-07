using System;
namespace VirtualAndOverride
{
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsHungry { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
            IsHungry = true;
        }

        //virtual so it can be overridden by specific animal class
        public virtual void MakeSound()
        {

        }
        public virtual void Eat()
        {
            if(IsHungry)
            {
                Console.WriteLine($"{Name} is not eating");
            }
            else
                Console.WriteLine($"{Name} is not hungry");
        }
        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing");
        }
    }
}
