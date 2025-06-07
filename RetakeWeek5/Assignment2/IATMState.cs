using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal interface IATMState
    {
        void InsertCard();
        void RejectCard();
        void EnterPincode(string pin);
        void WithdrawCash(int amount);
    }
}
