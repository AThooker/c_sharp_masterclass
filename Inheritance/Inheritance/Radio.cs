namespace Inheritance
{
        //child class
    class Radio : ElectricalDevice
    {
        public Radio(bool isOn, string brand):base(isOn, brand)
        {}
        public void ListenRadio()
        {
            if(IsOn)
            {
                System.Console.WriteLine("Listening to the Radio!");
            }
            else
                System.Console.WriteLine("Radio is switched off, switch it on first");
        }
    }
}
