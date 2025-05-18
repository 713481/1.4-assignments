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
            IStack myStack = new ArrayStack(50);
            AddValues(myStack);
            CheckValues(myStack);
            ProcessValues(myStack);
        }
        static void AddValues(IStack stack)
        {
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                int value = random.Next(0, 100);
                stack.Push(value);
                Console.WriteLine($"Added number: {value,2}, Count number: {stack.Count}");
            }
        }
        static void CheckValues(IStack stack)
        {
            Console.WriteLine();
            Console.WriteLine("Checking values...");
            // Checking every 20
            for (int i = 0; i < 100; i += 20)
            {
                Console.WriteLine($"Stack contains {i}: {stack.Contains(i)}");
            }
            Console.WriteLine();
            // Checking arrray
            int[] testNumbers = { 7, 69, 77, 2, 3, 4, 0 };
            foreach (int testNumber in testNumbers)
            {
                Console.WriteLine($"Stack contains {testNumber}: {stack.Contains(testNumber)}");
            }
            Console.WriteLine();
            // Checking random numbers
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                int testNumber = rand.Next(0, 100);
                Console.WriteLine($"Stack contains {testNumber}: {stack.Contains(testNumber)}");
            }
            Console.WriteLine();
        }
        static void ProcessValues(IStack stack)
        {
            while (!stack.IsEmpty)
            {
                int value = stack.Pop();
                Console.WriteLine($"Reverse number: {value}, Reverse Count: {stack.Count + 1}");
            }
        }
    }
}