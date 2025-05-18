namespace Assignment3
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
            IObservable player = new MP3Player();

            IObserver mp3Display1 = new SimpleMP3Display(player);
            IObserver mp3Display2 = new FancyMP3Display(player);

            player.NextSong();
            Console.WriteLine();
            player.NextSong();
            Console.WriteLine();
            player.NextSong();
        }
    }
}