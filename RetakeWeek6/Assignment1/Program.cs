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
            Console.WriteLine("[shop creating expensive computers]");
            ComputerShop highShop = new HighBudgetShop();
            Computer expensiveComputer = highShop.AssembleComputer();
            expensiveComputer.Test();

            Console.WriteLine();

            Console.WriteLine("[shop creating cheap computers]");
            ComputerShop lowShop = new LowBudgetShop();
            Computer cheapComputer = lowShop.AssembleComputer();
            cheapComputer.Test();
        }
    }
}