using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Members
    {
        //member - private field
        private string memberName;
        private string jobTitle;

        //member - public field
        public int age;

        //member - property = exposes jobTitle safely - properties start with capital letters
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }
        //public member Method - can be called from other classes

        public void Introducing(bool isFriend)
        {
            if(isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine($"Hi my name is {memberName}, and my job title is {JobTitle}, I am {age} years old.");
            }
        }
        private int salary = 20000;
        private void SharingPrivateInfo()
        {
            Console.WriteLine("My salary is " + salary);
        }

        // member constructor

        public Members()
        {
            age = 30;
            memberName = "Ted";
            salary = 60000;
            JobTitle = "Developer";
            Console.WriteLine("member constructor");
        }

        //member - finalizer - destructor
        //only one per class
        ~Members()
        {
            //cleanup statements
            Console.WriteLine("Deconstruction of members object");
            Debug.Write("Deconstruction of members object");
        }
    }
}
