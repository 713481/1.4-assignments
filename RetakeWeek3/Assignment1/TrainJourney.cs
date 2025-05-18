using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class TrainJourney : ITrainJourney
    {
        private List<TrainStation> stations;
        private List<ITrainDisplay> observers;
        private int currentIndex = -1;
        private bool nextStation = true;

        public TrainJourney()
        {
            observers = new List<ITrainDisplay>();
            stations = new List<TrainStation>
        {
            new TrainStation("Den Helder", "1a"),
            new TrainStation("Alkmaar", "2b"),
            new TrainStation("Amsterdam", "3c"),
            new TrainStation("Utrecht", "4d"),
            new TrainStation("Nijmegen", "5e")
        };
        }

        public void AddObserver(ITrainDisplay observer) => observers.Add(observer);
        public void RemoveObserver(ITrainDisplay observer) => observers.Remove(observer);

        public void NextStation()
        {
            if (nextStation)
            {
                if (currentIndex < stations.Count - 1)
                    currentIndex++;
                else
                {
                    nextStation = false;
                    currentIndex--;
                }
            }
            else
            {
                if (currentIndex > 0)
                    currentIndex--;
                else
                {
                    nextStation = true;
                    currentIndex++;
                }
            }

            NotifyObservers();
        }

        private void NotifyObservers()
        {
            TrainStation current = GetCurrentStation();
            foreach (var observer in observers)
                observer.Update(current);
        }

        public TrainStation GetCurrentStation() => currentIndex >= 0 && currentIndex < stations.Count ? stations[currentIndex] : null;
    }
}
