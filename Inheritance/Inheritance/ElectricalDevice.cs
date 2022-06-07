﻿namespace Inheritance
{
    //base class / parent class
    class ElectricalDevice
    {
        public bool IsOn { get; set; }
        public string Brand { get; set; }
        public ElectricalDevice(bool isOn, string brand)
        {
            IsOn = isOn;
            Brand = brand;
        }
        public void SwitchOn()
        {
            IsOn = true;
        }
        public void SwitchOff()
        {
            IsOn = false;
        }
    }
}