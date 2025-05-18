using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Song
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public double Time { get; set; }    

        public Song(string title, string artist, double time)
        {
            Title = title;
            Artist = artist;
            Time = time;
        }
    }
}
