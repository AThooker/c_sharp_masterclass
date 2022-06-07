using System;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Radio myRadio = new Radio(true, "Sony");
            myRadio.SwitchOff();
            myRadio.SwitchOn();
            myRadio.ListenRadio();
            TV myTv = new TV(true, "Samsung");
            myTv.SwitchOff();
            myTv.WatchTv();
        }
    }
}
