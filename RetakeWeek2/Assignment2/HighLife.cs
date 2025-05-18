using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwayGameOfLife
{
    public class HighLife : ConwayGameOfLife
    {
        protected override bool CellShouldLive(bool livingCell, int neighbourCount)
        {
            // HighLife rules (B36/S23)
            if (!livingCell && (neighbourCount == 3 || neighbourCount == 6))
                return true;
            if (livingCell && (neighbourCount == 2 || neighbourCount == 3))
                return true;
            return false;
        }
    }
}
