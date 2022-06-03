using System;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human austin = new Human("austin", "hooker", "blue", 26);
            austin.IntroduceName();
            Human bill = new Human("bill", "shark", "green");
            bill.IntroduceName();
            Human human = new Human();
        }
    }
}
