using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saper
{
    internal class Player
    {
        internal Position _position = new(0, 0);

        public void changePosition(int x, int y)
        {
            this._position.x = x;
            this._position.y = y;
        }
    }
}
