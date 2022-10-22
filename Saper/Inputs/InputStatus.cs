using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saper
{
    internal class InputStatus
    {
        internal InputPossibilities InputPossibilities { get; set; }
        internal InputStatus()
        {
            InputPossibilities = InputPossibilities.NONE;
        }
    }
}
