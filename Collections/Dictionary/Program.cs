using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees =
            {
                new Employee("CEO", "Gwyn", 75, 200),
                new Employee("Manager", "Meg", 75, 100),
                new Employee("CIO", "Ivan", 75, 150),
                new Employee("CFO", "Fred", 75, 160),
                new Employee("Developer", "Debby", 75, 120),
                new Employee("Intern", "Ingrid", 75, 20),
            };
            Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();
            foreach (Employee employee in employees)
            {
                employeesDirectory.Add(employee.Role, employee);
            }

            for(int i = 0; i < employeesDirectory.Count; i++)
            {
                KeyValuePair<string, Employee> keyValuePair = employeesDirectory.ElementAt(i);
                Console.WriteLine($"Key: {keyValuePair.Key}");
                Employee employee = keyValuePair.Value;
                Console.WriteLine($"Employee name: {employee.Name}\n" +
                    $"Role: {employee.Role}\n" +
                    $"Age: {employee.Age}\n" +
                    $"Salary: {employee.Salary}\n");
            }
            Console.ReadKey();
            //Remove
            if (employeesDirectory.ContainsKey("Intern"))
            {
                bool removeEmp = employeesDirectory.Remove("Intern");
                if(removeEmp)
                {
                    Console.WriteLine("Intern removed....forever");
                }
            }

            //else
            //    Console.WriteLine("Key doesn't exist");

            //if(employeesDirectory.TryGetValue("Intern", out Employee result))
            //{
            //    Console.WriteLine($"Intern name: {result.Name}\n" +
            //        $"Intern salary: {result.Salary}");
            //}
            //else
            //    Console.WriteLine("Key does not exist");
            Console.WriteLine(DictionaryChallenge(4));
            Console.WriteLine(DictionaryChallenge(1));
            Console.WriteLine(DictionaryChallenge(8));
        }

        //dictionary
        //Generic-type, has to hold one type of both key and value
        //Key - value

        //declaration
        //Dicitonary<int, string> myDict = new Dicitionary<int, string>();

        private static void PracticeDictionary()
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>()
            {
                {2, "Hello" },
                {3, "Hello"}
            };

            myDictionary.Add(1, "Hello");
        }
        private static string DictionaryChallenge(int i)
        {
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>()
            {
                {1, "one" },
                {2, "two"},
                {3, "three"},
                {4, "four"},
                {5, "five"}
            };
            if(!keyValuePairs.ContainsKey(i))
            {
                return "Nope";
            }
            return keyValuePairs[i];
        }
    }
}
