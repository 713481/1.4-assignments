using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal interface IAttacker
    {
        string Driver { get; }
        void AssignDriver(string driverName);
        void DriveForward();
        void UseWeapon();
    }
}
