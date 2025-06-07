using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Computer
    {
        private IProcessor processor;
        private IHardDisk hardDisk;
        private IMonitor monitor;

        public Computer(IProcessor processor, IHardDisk hardDisk, IMonitor monitor)
        {
            this.processor = processor;
            this.hardDisk = hardDisk;
            this.monitor = monitor;
        }

        public void Test()
        {
            processor.PerformOperation();
            hardDisk.StoreData();
            monitor.Display();
        }
    }
}
