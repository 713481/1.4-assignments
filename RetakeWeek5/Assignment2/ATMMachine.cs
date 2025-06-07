using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class ATMMachine
    {
        private IATMState machineState;

        private IATMState noCard;
        private IATMState cardPresent;
        private IATMState correctPinCode;
        private IATMState noCash;

        private double amountInMachine;

        public ATMMachine(double initialAmount)
        {
            this.amountInMachine = initialAmount;

            noCard = new NoCardState(this);
            cardPresent = new CardPresentState(this);
            correctPinCode = new CorrectPinState(this);
            noCash = new NoCashState(this);

            if (initialAmount > 0)
                machineState = noCard;
            else
                machineState = noCash;
        }

        public void InsertCard()
        {
            machineState.InsertCard();
        }

        public void RejectCard()
        {
            machineState.RejectCard();
        }

        public void EnterPincode(string pincode)
        {
            machineState.EnterPincode(pincode);
        }

        public void WithdrawCash(int amount)
        {
            machineState.WithdrawCash(amount);
        }

        public void SetMachineState(IATMState state)
        {
            this.machineState = state;
        }
        public IATMState GetNoCardState() => noCard;
        public IATMState GetCardPresentState() => cardPresent;
        public IATMState GetCorrectPinState() => correctPinCode;
        public IATMState GetNoCashState() => noCash;

        public double AmountInMachine => amountInMachine;

        public void SetAmountInMachine(double amount)
        {
            amountInMachine = amount;
        }
    }
}
