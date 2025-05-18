using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class TrainStation
    {
        public string Name { get; set; }
        public string Track { get; set; }

        public TrainStation(string name, string track)
        {
            Name = name;
            Track = track;
        }
    }
}
