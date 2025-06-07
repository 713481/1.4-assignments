using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Queen : Character
    {
        public Queen() : base(new KnifeBehaviour()) { }
    }
    internal class Troll : Character
    {
        public Troll() : base(new AxeBehaviour()) { }
    }
    internal class King : Character
    {
        public King() : base(new BowAndArrowBehaviour()) { }
    }
    internal class Knight : Character
    {
        public Knight() : base(new SwordBehaviour()) { }
    }
}