using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class TrainDisplay : Form, ITrainDisplay
    {
        private static int count = 1;
        public TrainDisplay()
        {
            InitializeComponent();
            this.Text = $"TrainDisplay #{count++}";
        }

        private void TrainDisplay_Load(object sender, EventArgs e)
        {

        }

        public void Update(TrainStation station)
        {
            if (station != null)
            {
                labelStation.Text = $"Current station: {station.Name}";
                labelTrack.Text = $"Railway Track: {station.Track}";
            }
        }
    }
}
