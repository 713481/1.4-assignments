using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class TrainController : ITrainController
    {
        private ITrainJourney journey;

        public TrainController(ITrainJourney journey)
        {
            this.journey = journey;
        }

        public void NextStation()
        {
            journey.NextStation();
        }
    }
}
