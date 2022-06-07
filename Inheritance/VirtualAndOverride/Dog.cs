using System;

namespace VirtualAndOverride
{
    class Dog : Animal
    {
        public bool IsHappy { get; set; }
        public Dog(string name, int age) : base(name, age)
        {
            IsHappy = true;
        }
        //override the base classes Eat() method
        public override void Eat()
        {
            //calling the method of the base class
            base.Eat();
        }
        public override void MakeSound()
        {
            Console.WriteLine("Woof Woof");
        }
        public override void Play()
        {
            if(IsHappy)
                base.Play();
        }
    }
}
