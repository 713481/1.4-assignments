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
            IPencil pencil = new Pencil(20);
            IPencilSharpener sharpener = new PencilSharpener();

            while (true)
            {
                Console.Write("Enter message: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "stop")
                    break;
                if (input.ToLower() == "sharpen")
                {
                    sharpener.Sharpen(pencil);
                    Console.WriteLine("Pencil sharpened.");
                    continue;
                }
                pencil.Write(input);
            }
        }
    }
}