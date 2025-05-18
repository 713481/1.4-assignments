namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            BatchProcessor processor = new BatchProcessor();

            processor.AddLoader(new CallDataLoader());
            processor.AddLoader(new TwitterDataLoader());
            processor.AddLoader(new SensorDataLoader());

            processor.ProcessBatch();
        }
    }
}