using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class ComputerShop
    {
        private ComputerFactory factory;

        public ComputerShop(ComputerFactory factory)
        {
            this.factory = factory;
        }

        public Computer AssembleComputer()
        {
            var processor = factory.CreateProcessor();
            var hardDisk = factory.CreateHardDisk();
            var monitor = factory.CreateMonitor();
            return new Computer(processor, hardDisk, monitor);
        }
    }
}
