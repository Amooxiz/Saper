using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saper
{
    internal class rankingModel
    {
        public string nick;
        public string time;
        public long ms;
        public rankingModel(string nick, string time, long ms)
        {
            this.nick = nick;
            this.ms = ms;
            this.time = time;
        }
    }

    internal static class rankingController
    {
        public static List<rankingModel> getRanking(string path)
        {
            List<rankingModel> list = new List<rankingModel>();
            string[] s = Reader.readFromFile(path);
            foreach (string s2 in s)
            {
                string[] splitted = s2.Split(' ');
                list.Add(new rankingModel(splitted[0], splitted[1], long.Parse(splitted[2])));
            }
            return list;
        }

        public static void saveRankingToFile(List<rankingModel> list, string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (rankingModel model in list)
                {
                    writer.WriteLine($"{model.nick} {model.time} {model.ms.ToString()}");
                }
            }
        }

        public static void printRanking(List<rankingModel> list, Position position)
        {
            var listt = list.OrderBy(l => l.ms);
            Console.SetCursorPosition(position.x, position.y);
            foreach (rankingModel model in listt)
            {
                Console.Write($"{model.nick} {model.time}");
                Console.SetCursorPosition(position.x, Console.CursorTop + 2);
            }
        }
    }
}
