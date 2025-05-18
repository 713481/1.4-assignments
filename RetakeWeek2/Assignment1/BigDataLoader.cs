using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public abstract class BigDataLoader
    {
        public void ETL()
        {
            Extract();
            Transform();
            Load();
        }

        protected abstract void Extract();
        protected abstract void Transform();

        protected virtual void Load()
        {
            Console.WriteLine("Loading transformed data...");
        }
    }
}
