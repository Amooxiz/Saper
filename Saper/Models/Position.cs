using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saper
{
    internal class Position
    {
        internal int x { get; set; }
        internal int y { get; set; }

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
