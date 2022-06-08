using System;

namespace InheritanceChallenge_Employees
{
    class Trainee : Employee
    {
        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }

        public Trainee()
        {

        }
        public Trainee(string name, string title, double salary, int workingHours, int schoolHours) : base(name, title, salary)
        {
            WorkingHours = workingHours;
            SchoolHours = schoolHours;
        }
        public void Learn()
        {
            Console.WriteLine($"Learning hours(School): {SchoolHours}");
        }
        public override void Work()
        {
            Console.WriteLine($"Working hours for this trainee {WorkingHours}");
        }
    }
}
