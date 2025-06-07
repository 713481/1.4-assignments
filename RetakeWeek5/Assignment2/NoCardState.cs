using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class NoCardState : IATMState
    {
        private ATMMachine machine;

        public NoCardState(ATMMachine machine)
        {
            this.machine = machine;
        }
        public void InsertCard()
        {
            Console.WriteLine("Card has been inserted");
            machine.SetMachineState(machine.GetCardPresentState());
        }

        public void RejectCard()
        {
            Console.WriteLine("No card to reject");
        }

        public void EnterPincode(string pincode)
        {
            Console.WriteLine("Please insert a card first");
        }

        public void WithdrawCash(int amount)
        {
            Console.WriteLine("Please insert a card first");
        }
    }
}
