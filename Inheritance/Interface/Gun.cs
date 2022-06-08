using System;
namespace Interface
{
    class Gun : Weapon, IShootable
    {
        public Gun()
        {
            name = "Gun";
        }
        public void Shoot()
        {
            Console.WriteLine("Bang!");
        }
    }
}
