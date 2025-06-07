using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Tank : IAttacker
    {
        private string driver;
        public string Driver => driver;

        public void AssignDriver(string driverName)
        {
            driver = driverName;
            Console.WriteLine($"{driver} is steering the tank");
        }

        public void DriveForward()
        {
            Console.WriteLine("Tank moves forward");
        }

        public void UseWeapon()
        {
            Console.WriteLine("Tank causes damage with weapon");
        }
    }
}
