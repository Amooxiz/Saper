using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saper
{
    internal static class Reader
    {
        public static string[] readFromFile(string path)
        {
            string[] result = File.ReadAllLines(path);
            return result;
        }
    }
}
