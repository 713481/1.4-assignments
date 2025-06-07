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
            Logger.GetInstance().Log("Program", "starting");

            MainSystem mainSystem = new MainSystem();
            mainSystem.DoSomeMainWork();

            Logger.GetInstance().Log("Program", "finishing");
        }
    }
}