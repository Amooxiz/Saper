using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saper
{
    public static class GlobalAccessClass
    {
        public static bool isFinished = false;
        public static bool isWin = false;
        public static int diffLevel;
        public static int minutes = 0;
        public static int seconds = 0;
        public static string nick;
        public static string time;
        public static long ms;
        public static List<Position> minePositions;
        public static int msToTime;
    }
}
