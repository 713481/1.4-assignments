namespace Assignment1
{
    public partial class ControlPanel : Form
    {
        private ITrainJourney journey;
        private ITrainController controller;

        public ControlPanel()
        {
            InitializeComponent();

            journey = new TrainJourney();
            controller = new TrainController(journey);
        }

        private void ControlPanel_Load(object sender, EventArgs e)
        {
        }
        private void btnNextStation_Click(object sender, EventArgs e)
        {
            controller.NextStation();
        }

        private void btnNewDisplay_Click(object sender, EventArgs e)
        {
            var display = new TrainDisplay();
            journey.AddObserver(display);
            display.Show();
        }

    }
}
