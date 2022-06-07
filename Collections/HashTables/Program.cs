using System;
using System.Collections;

namespace HashTables
{
    internal class Program
    {
        //Hashtable - Non-generic (can have many types)
        //Key - Value
        //ID  - Name

        static void Main(string[] args)
        {
            HashTableChallenge();
        }

        private static void HashTableChallenge()
        {
            Student[] students = new Student[5];
            students[0] = new Student(1, "Tom", 3.14f);
            students[1] = new Student(2, "Tim", 3.14f);
            students[2] = new Student(3, "Sam", 3.14f);
            students[3] = new Student(1, "Ted", 3.14f);
            students[4] = new Student(5, "Tina", 3.14f);

            Hashtable studentHash = new Hashtable();

            foreach(Student student in students)
            {
                if(studentHash.ContainsKey(student.Id))
                {
                    Console.WriteLine($"A student with the same ID already Exists\n" +
                        $"{student.Name} will not be entered with this id");
                }
                else
                    studentHash.Add(student.Id, student);
            }
            Console.WriteLine($"\nStudents currently in the hashtable\n");
            foreach(Student kiddo in studentHash.Values)
            {
                Console.WriteLine(kiddo.Name);
            }
        }
        private static void PracticeHashTable()
        {
            Hashtable studentsTable = new Hashtable();
            Student studOne = new Student(1, "Tim", 3.75f);
            Student studTwo = new Student(2, "Ted", 2.75f);
            Student studThree = new Student(3, "Tom", 4.00f);
            studentsTable.Add(studOne.Id, studOne);
            studentsTable.Add(studTwo.Id, studTwo);
            studentsTable.Add(studThree.Id, studThree);

            Student storedStudent = (Student)studentsTable[studOne.Id];
            //each entry in a hashtable is considered a "dictionary entry"
            //a hashtable is a collection of dictionary entries
            foreach (DictionaryEntry entry in studentsTable)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine(temp.Name);
                Console.WriteLine(temp.GPA + "\n");
            }
            Console.WriteLine($"{storedStudent.Name} has an id of {storedStudent.Id} and a gpa of {storedStudent.GPA}");
        }
    }
}
