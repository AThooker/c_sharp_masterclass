using System;
namespace InheritanceChallenge_Employees
{
    class Manager : Employee
    {
        public string CompanyCar { get; set; }
        public Manager()
        {

        }
        public Manager(string name, string title, double salary, string companyCar) : base(name, title, salary)
        {
            CompanyCar = companyCar;
        }

        public void Lead()
        {
            Console.WriteLine("This manager is now leading");
        }
        public override string ToString()
        {
            return String.Format($"{Name} has the title of {Title}, with a salary of {Salary}, and a {CompanyCar} company vehicle");
        }
    }
}
