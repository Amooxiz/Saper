using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Saper
{
    internal class InputPicker
    {
        internal static InputStatus getInput()
        {
            var input = new InputStatus();
            var _key = Console.ReadKey(true);

            switch (_key.Key)
            {
                case ConsoleKey.UpArrow:
                    input.InputPossibilities = InputPossibilities.UP;
                    break;
                case ConsoleKey.DownArrow:
                    input.InputPossibilities = InputPossibilities.DOWN;
                    break;
                case ConsoleKey.LeftArrow:
                    input.InputPossibilities = InputPossibilities.LEFT;
                    break;
                case ConsoleKey.RightArrow:
                    input.InputPossibilities = InputPossibilities.RIGHT;
                    break;
                case ConsoleKey.Z:
                    input.InputPossibilities = InputPossibilities.MARK;
                    break;
                case ConsoleKey.X:
                    input.InputPossibilities = InputPossibilities.UNCOVER;
                    break;
                case ConsoleKey.Enter:
                    input.InputPossibilities = InputPossibilities.ENTER;
                    break;
                default:
                    input.InputPossibilities = InputPossibilities.NONE;
                    break;
            }
            return input;

        }
    }
}
