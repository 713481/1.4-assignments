using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class BatchProcessor
    {
        private List<BigDataLoader> loaders = new List<BigDataLoader>();

        public void AddLoader(BigDataLoader loader)
        {
            loaders.Add(loader);
        }

        public void ProcessBatch()
        {
            foreach (var loader in loaders)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("[ETL-proces started]");
                Console.ForegroundColor = ConsoleColor.White;
                loader.ETL();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("[ETL-proces finished]");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            }
        }
    }
}
