using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class SubSystem
    {
        public SubSystem() { }

        public void DoSomeWork()
        {
            Logger.GetInstance().Log("SubSystem", "doing some work");
        }

        public void DoSomeMoreWork()
        {
            Logger.GetInstance().Log("SubSystem", "doing some more work");
        }
    }
}
