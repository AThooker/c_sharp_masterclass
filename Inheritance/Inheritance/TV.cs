using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class TV : ElectricalDevice
    {
        public TV(bool isOn, string brand):base(isOn, brand)
        {
        }
        public void WatchTv()
        {
            if(IsOn)
            {
                Console.WriteLine("You are watching TV");
            }
            else
                Console.WriteLine("turn tv on first");
        }
    }
}
