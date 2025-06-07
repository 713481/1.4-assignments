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
            ATMMachine machine = new ATMMachine(2000);

            while (true)
            {
                Console.Write("\nPlease enter your command:");
                Console.ForegroundColor = ConsoleColor.Green;
                string input = Console.ReadLine()?.ToLower();
                Console.ResetColor();

                switch (input)
                {
                    case "insert card":
                        machine.InsertCard();
                        break;

                    case "reject card":
                        machine.RejectCard();
                        break;

                    case "enter pincode":
                        Console.Write("Please enter your pincode:");
                        string pin = Console.ReadLine();
                        machine.EnterPincode(pin);
                        break;

                    case "withdraw cash":
                        Console.Write("Please enter amount of cash:");
                        if (int.TryParse(Console.ReadLine(), out int amount))
                        {
                            machine.WithdrawCash(amount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount");
                        }
                        break;

                    case "stop":
                        return;

                    default:
                        Console.WriteLine("Entered unknown command");
                        break;
                }
            }
        }
    }
}