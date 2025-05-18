using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Pencil : IPencil
    {
        private int maxToWrite;
        private int nrOfCharsWritten;

        public Pencil(int maxChar) 
        { 
            this.maxToWrite = maxChar;
            this.nrOfCharsWritten = 0;
        }

        public bool CanWrite => nrOfCharsWritten < maxToWrite;

        public void Write(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (nrOfCharsWritten < maxToWrite)
                {
                    Console.Write(input[i]);
                }
                else
                {
                    Console.Write("#");
                }
                nrOfCharsWritten++;
            }
            Console.WriteLine();
        }

        public void AfterSharpening()
        {
            nrOfCharsWritten = 0;
        }
    }
}
