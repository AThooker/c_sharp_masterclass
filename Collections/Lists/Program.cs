using System;
using System.Collections;
using System.Collections.Generic;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //WorkingWithArrayLists();
            var testAnswer = ListsChallenge();
            foreach(var item in testAnswer)
            {
                Console.WriteLine(item);
            }
        }
        #region ArrayLists
        //private so only inside this class
        private static void WorkingWithArrayLists()
        {
            //ArrayList is non-generic meaning you can add many types to it
            ArrayList arrayList = new ArrayList();
            arrayList.Add(25);
            arrayList.Add(25);
            arrayList.Add(25);
            arrayList.Add("Hello");
            arrayList.Add(13.47);
            arrayList.Add(2.43f);
            arrayList.Add('O');

            //remove the value (only the first value, hence if there were another 25, it would still be in the arrayList)
            arrayList.Remove(25);
            //remove at index
            arrayList.RemoveAt(1);
            Console.WriteLine(arrayList.Count);
            double sum = 0;
            foreach(object obj in arrayList)
            {
                //Console.WriteLine(obj);
                if(obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if(obj is double)
                {
                    sum += (double)obj;
                }
                else if(obj is string)
                {
                    Console.WriteLine(obj);
                }
            }
            Console.WriteLine(sum);
            //List is generic, menaing only one type
        }
        #endregion
        //internal so only in this assembly
        internal static List<int> ListsChallenge()
        {
            List<int> myList = new List<int>();
            for(int i = 100; i <= 170; i+=2)
            {
                myList.Add(i);
            }
            return myList;
        }
    }
}
