using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class CorrectPinState : IATMState
    {
        private ATMMachine machine;
        public CorrectPinState(ATMMachine machine) 
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
            Console.WriteLine("Why would you put in your pincode again... try something else...");
        }

        public void WithdrawCash(int amount)
        {
            if (amount > machine.AmountInMachine)
            {
                Console.WriteLine("Not enough cash available in machine");
                Console.WriteLine("Your card has been rejected");
                machine.SetMachineState(machine.GetNoCardState());
            }
            else
            {
                Console.WriteLine($"{amount} withdrawn from machine");
                machine.SetAmountInMachine(machine.AmountInMachine - amount);
                if (machine.AmountInMachine <= 0)
                {
                    machine.SetMachineState(machine.GetNoCashState());
                }
                else
                {
                    machine.SetMachineState(machine.GetNoCardState());
                }
                    Console.WriteLine("Your card has been rejected");
            }

        }
    }
}
