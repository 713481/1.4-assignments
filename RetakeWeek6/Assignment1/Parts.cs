using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class CheapProcessor : IProcessor
    {
        public void PerformOperation() => Console.WriteLine("performing operation not so quickly...");
    }

    class ExpensiveProcessor : IProcessor
    {
        public void PerformOperation() => Console.WriteLine("performing operation very quickly...");
    }

    class CheapHardDisk : IHardDisk
    {
        public void StoreData() => Console.WriteLine("storing data not so quickly...");
    }

    class ExpensiveHardDisk : IHardDisk
    {
        public void StoreData() => Console.WriteLine("storing data very quickly...");
    }

    class CheapMonitor : IMonitor
    {
        public void Display() => Console.WriteLine("displaying stuff very poor...");
    }

    class ExpensiveMonitor : IMonitor
    {
        public void Display() => Console.WriteLine("displaying stuff very nice...");
    }
}
