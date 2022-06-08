using System;

namespace InheritanceChallenge_Employees
{
    class Employee
    {
        protected int ID { get; set; }
        protected string Name { get; set; }
        protected string Title { get; set; }
        protected double Salary { get; set; }
        public Employee()
        {

        }
        public Employee(string name, string title, double salary)
        {
            ID = GetNextID();
            Name = name;
            Title = title;
            Salary = salary;
        }
        private int currentID = 0;
        protected int GetNextID()
        {
            return ++currentID;
        }
        public override string ToString()
        {
            return String.Format($"{Name} has the title of {Title}, with a salary of {Salary}");
        }
        public virtual void Work()
        {
            Console.WriteLine("Working now");
        }
        protected virtual void Pause()
        {
            Console.WriteLine("Working paused");
        }
    }
}
