using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwayGameOfLife
{
    public class StandardLife : ConwayGameOfLife
    {
        protected override bool CellShouldLive(bool livingCell, int neighbourCount)
        {
            // Standard Conway’s rules (B3/S23)
            if (!livingCell && neighbourCount == 3)
                return true;
            if (livingCell && (neighbourCount == 2 || neighbourCount == 3))
                return true;
            return false;
        }
    }
}
