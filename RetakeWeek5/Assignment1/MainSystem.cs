using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class MainSystem
    {
        public MainSystem() 
        {

        }
        public void DoSomeMainWork()
        {
            Logger.GetInstance().Log("MainSystem", "doing some main work");

            SubSystem subSystem = new SubSystem();
            subSystem.DoSomeWork();
            subSystem.DoSomeMoreWork();
        }
    }
}
