
using Saper;
using System.Diagnostics;
using System.Threading;

Console.Title = "Minesweeper";

MenuController menu = new MenuController();

Console.SetCursorPosition(47, 10);
Console.WriteLine("Please enter your nickname");
Console.SetCursorPosition(52, 12);
GlobalAccessClass.nick = Console.ReadLine();
menu.printMenu();
while (true)
{
    menu.startMenu();
}
