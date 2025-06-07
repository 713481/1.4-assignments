namespace Assignment2
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
            ComputerFactory expensiveFactory = new HighBudgetFactory();
            ComputerShop expensiveShop = new ComputerShop(expensiveFactory);
            Computer expensiveComputer = expensiveShop.AssembleComputer();
            expensiveComputer.Test();

            Console.WriteLine();

            Console.WriteLine("[shop creating cheap computers]");
            ComputerFactory cheapFactory = new LowBudgetFactory();
            ComputerShop cheapShop = new ComputerShop(cheapFactory);
            Computer cheapComputer = cheapShop.AssembleComputer();
            cheapComputer.Test();
        }
    }
}