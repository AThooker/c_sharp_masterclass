using System;

namespace InheritanceChallenge_Employees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Ted","Developer", 60000);
            Manager manager = new Manager("Austin", "Architect", 95000, "Four Runner");
            Trainee trainee = new Trainee("Timmy", "trainee for developer", 45000, 25, 15);
            Console.WriteLine(employee.ToString());
            Console.WriteLine(manager.ToString());
            manager.Lead();
            Console.WriteLine(trainee.ToString());
            trainee.Work();
        }
    }
}
