using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal interface ITrainJourney
    {
        void NextStation();
        void AddObserver(ITrainDisplay observer);
        void RemoveObserver(ITrainDisplay observer);
        TrainStation GetCurrentStation();
    }
}
