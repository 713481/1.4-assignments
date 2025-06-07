using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class CardPresentState : IATMState
    {
        private ATMMachine machine;

        public CardPresentState(ATMMachine machine)
        {
            this.machine = machine;
        }
        public void InsertCard()
        {
            Console.WriteLine("A card has been inserted already");
        }

        public void RejectCard()
        {
            Console.WriteLine("Card has been rejected");
            machine.SetMachineState(machine.GetNoCardState());
        }

        public void EnterPincode(string pincode)
        {
            if (pincode == "1234")
            {
                Console.WriteLine("You have entered the correct pincode");
                machine.SetMachineState(machine.GetCorrectPinState());
            }
            else
            {
                Console.WriteLine("Wrong pincode");
            }
        }

        public void WithdrawCash(int amount)
        {
            Console.WriteLine("Please enter your pincode first!");
        }
    }
}
