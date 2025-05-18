using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class MP3Player : IObservable
    {
        private List<IObserver> observers = new List<IObserver>();
        private List<Song> songs = new List<Song>();
        private Random random = new Random();

        public Song CurrentSong { get; private set; }

        public MP3Player()
        {
            songs.Add(new Song("Papillon", "Editors", 5.24));
            songs.Add(new Song("Wish You Were Here", "Pink Floyd", 5.39));
            songs.Add(new Song("Dazed and Confused", "Led Zeppelin", 6.26));
            songs.Add(new Song("Billionaire", "Bruno Mars", 3.31));
        }

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NextSong()
        {
            CurrentSong = songs[random.Next(songs.Count)];

            foreach (var observer in observers)
            {
                observer.Update(CurrentSong);
            }
        }
    }
}
