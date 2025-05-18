using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class SimpleMP3Display : IObserver
    {
        public SimpleMP3Display(IObservable player)
        {
            player.AddObserver(this);
        }

        public void Update(Song song)
        {
            Console.WriteLine($"Simple display: {song.Artist} - {song.Title}");
        }
    }
}
