using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    abstract class ComputerShop
    {
        public Computer AssembleComputer()
        {
            IProcessor cpu = CreateProcessor();
            IHardDisk disk = CreateHardDisk();
            IMonitor monitor = CreateMonitor();

            return new Computer(cpu, disk, monitor);
        }

        public abstract IProcessor CreateProcessor();
        public abstract IHardDisk CreateHardDisk();
        public abstract IMonitor CreateMonitor();
    }
}
