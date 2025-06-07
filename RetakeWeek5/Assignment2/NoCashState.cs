using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class NoCashState : IATMState
    {
        private ATMMachine machine;

        public NoCashState(ATMMachine machine)
        {
            this.machine = machine;
        }
        public void InsertCard()
        {
            Console.WriteLine("ATM is out of service");
        }

        public void RejectCard()
        {
            Console.WriteLine("ATM is out of service");
        }

        public void EnterPincode(string pincode)
        {
            Console.WriteLine("ATM is out of service");
        }

        public void WithdrawCash(int amount)
        {
            Console.WriteLine("ATM is out of service");
        }
    }
}
