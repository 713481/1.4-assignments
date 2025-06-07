using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class LowBudgetShop : ComputerShop
    {
        public override IProcessor CreateProcessor() => new CheapProcessor();
        public override IHardDisk CreateHardDisk() => new CheapHardDisk();
        public override IMonitor CreateMonitor() => new CheapMonitor();
    }

    class HighBudgetShop : ComputerShop
    {
        public override IProcessor CreateProcessor() => new ExpensiveProcessor();
        public override IHardDisk CreateHardDisk() => new ExpensiveHardDisk();
        public override IMonitor CreateMonitor() => new ExpensiveMonitor();
    }
}
