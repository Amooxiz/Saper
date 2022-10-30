using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saper
{
    public static class CursorLock
    {
        public static readonly object Lock = new object();
    }
}
