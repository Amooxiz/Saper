using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saper
{
    internal class StopwatchController
    {
        public Stopwatch stopwatch = new Stopwatch();
        public int seconds = 0;
        public int minutes = 0;
        public int exSeconds = 0;
        public int exMinutes = 0;
        public const int numSizeX = 20;
        public const int numSizeY = 11;
        public Position position1 = new Position(1, 1);
        public Position position2 = new Position(1 + (20 * 1) + (1 * 1), 1);
        public Position position3 = new Position(1 + (20 * 2) + (1 * 2), 1);
        public Position position4 = new Position(1 + (20 * 3) + (1 * 3), 1);
        public Position position5 = new Position(1 + (20 * 4) + (1 * 4), 1);

        public string[] zero = Reader.readFromFile(ConstPaths.zero);
        public string[] one = Reader.readFromFile(ConstPaths.one);
        public string[] two = Reader.readFromFile(ConstPaths.two);
        public string[] three = Reader.readFromFile(ConstPaths.three);
        public string[] four = Reader.readFromFile(ConstPaths.four);
        public string[] five = Reader.readFromFile(ConstPaths.five);
        public string[] six = Reader.readFromFile(ConstPaths.six);
        public string[] seven = Reader.readFromFile(ConstPaths.seven);
        public string[] eight = Reader.readFromFile(ConstPaths.eight);
        public string[] nine = Reader.readFromFile(ConstPaths.nine);
        public string[] colon = Reader.readFromFile(ConstPaths.colon);

        public StopwatchController()
        {

        }


        public void threadTimer()
        {
            
            stopwatch.Start();
            printTimer();
            while (!GlobalAccessClass.isFinished)
            {
                long curr = stopwatch.ElapsedMilliseconds;
                seconds =(int) ((curr / 1000) % 60);
                minutes =(int) ((curr / 1000) / 60);

                GlobalAccessClass.seconds = seconds;
                GlobalAccessClass.minutes = minutes;
                GlobalAccessClass.ms = curr;
                GlobalAccessClass.time = $"{minutes}:{seconds}";

                if (exSeconds < seconds)
                {
                    var secondsToString = seconds.ToString();
                    var exSecondsToString = exSeconds.ToString();
                    if (secondsToString.Length == 2 && exSecondsToString.Length == 2)
                    {
                        if (secondsToString[1] != exSecondsToString[1] && secondsToString[0] != exSecondsToString[0])
                        {
                            numberInterpreter(secondsToString[0], position4);
                            numberInterpreter(secondsToString[1], position5);
                        }
                        else if (secondsToString[1] != exSecondsToString[1])
                        {
                            numberInterpreter(secondsToString[1], position5);
                        }
                    }
                    else if (secondsToString.Length == 2 && exSecondsToString.Length == 1)
                    {
                        numberInterpreter(secondsToString[0], position4);
                        numberInterpreter(secondsToString[1], position5);
                    }
                    else if (secondsToString.Length == 1 && exSecondsToString.Length == 1)
                    {
                        numberInterpreter(secondsToString[0], position5);
                    }
                }
                else if (exSeconds > seconds) // minute passed
                {
                    var secondsToString = seconds.ToString();
                    var minutesToString = minutes.ToString();
                    var exMinutesToString = exMinutes.ToString();
                    updateNum(zero, position4);
                    numberInterpreter(secondsToString[0], position5);
                    if (minutesToString.Length == 2 && exMinutesToString.Length == 2)
                    {
                        if (minutesToString[1] != exMinutesToString[1] && minutesToString[0] != exMinutesToString[0])
                        {
                            numberInterpreter(minutesToString[0], position1);
                            numberInterpreter(minutesToString[1], position2);
                        }
                        else if (minutesToString[1] != exMinutesToString[1])
                        {
                            numberInterpreter(minutesToString[1], position2);
                        }
                    }
                    else if (minutesToString.Length == 2 && exMinutesToString.Length == 1)
                    {
                        numberInterpreter(minutesToString[0], position1);
                        numberInterpreter(minutesToString[1], position2);
                    }
                    else if (minutesToString.Length == 1 && exMinutesToString.Length == 1)
                    {
                        numberInterpreter(minutesToString[0], position2);
                    }
                }
                exSeconds = seconds;
                exMinutes = minutes;
            }
        }

        public void printTimer()
        {
            lock (CursorLock.Lock)
            {
                Console.BackgroundColor = PixelColours.envColor;
                Console.SetCursorPosition(position1.x, position1.y);
                foreach (string s in zero)
                {
                    Console.Write(s);
                    Console.SetCursorPosition(position1.x, Console.CursorTop + 1);
                }
                Console.SetCursorPosition(position2.x, position2.y);
                foreach (string s in zero)
                {
                    Console.Write(s);
                    Console.SetCursorPosition(position2.x, Console.CursorTop + 1);
                }
                Console.SetCursorPosition(position3.x, position3.y);
                foreach (string s in colon)
                {
                    Console.Write(s);
                    Console.SetCursorPosition(position3.x, Console.CursorTop + 1);
                }
                Console.SetCursorPosition(position4.x, position4.y);
                foreach (string s in zero)
                {
                    Console.Write(s);
                    Console.SetCursorPosition(position4.x, Console.CursorTop + 1);
                }
                Console.SetCursorPosition(position5.x, position5.y);
                foreach (string s in zero)
                {
                    Console.Write(s);
                    Console.SetCursorPosition(position5.x, Console.CursorTop + 1);
                }
            }
        }

        public void numberInterpreter(char number, Position position)
        {
            switch (number)
            {
                case '0':
                    updateNum(this.zero, position);
                    break;
                case '1':
                    updateNum(this.one, position);
                    break;
                case '2':
                    updateNum(this.two, position);
                    break;
                case '3':
                    updateNum(this.three, position);
                    break;
                case '4':
                    updateNum(this.four, position);
                    break;
                case '5':
                    updateNum(this.five, position);
                    break;
                case '6':
                    updateNum(this.six, position);
                    break;
                case '7':
                    updateNum(this.seven, position);
                    break;
                case '8':
                    updateNum(this.eight, position);
                    break;
                case '9':
                    updateNum(this.nine, position);
                    break;

            }
        }

        public void updateNum(string[] num, Position position)
        {
            lock (CursorLock.Lock)
            {
                Console.BackgroundColor = PixelColours.envColor;

                for (int i = position.y + 2; i < (position.y + 2) + numSizeY - 4; i++)
                {
                    Console.SetCursorPosition(position.x + 5, i);
                    Console.Write("          ");
                }

                Console.SetCursorPosition(position.x, position.y);

                for (int i = position.y ; i < position.y + numSizeY; i++)
                {
                    Console.SetCursorPosition(position.x, i);
                    Console.Write(num[i - position.y]);
                }
            }
        }
    }
}
