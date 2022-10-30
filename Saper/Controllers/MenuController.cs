using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Media;

namespace Saper
{
    internal class MenuController
    {
        public SoundPlayer changePositionPlayer = new SoundPlayer(Path.GetFullPath(ConstPaths.positionChangeSound));
        public SoundPlayer changeMenuPlayer = new SoundPlayer(Path.GetFullPath(ConstPaths.menuChangeSound));
        public SoundPlayer startGamePlayer = new SoundPlayer(Path.GetFullPath(ConstPaths.startSound));
        public bool menuExitFlag = false;
        public bool menuExitFlag2 = false;
        public int currPositionMenu = 0;
        public int currPositionDifficulty = 0;
        public const int menuPositionLimit = 3;
        public const int difficultyPositionLimit = 2;
        public string[] play = Reader.readFromFile(ConstPaths.play);
        public string[] ranking = Reader.readFromFile(ConstPaths.ranking);
        public string[] controls = Reader.readFromFile(ConstPaths.controls);
        public string[] exit = Reader.readFromFile(ConstPaths.exit);
        public string[] exitMsg = Reader.readFromFile(ConstPaths.exitMsg);
        public string[] title = Reader.readFromFile(ConstPaths.title);
        public string[] leftArrow = Reader.readFromFile(ConstPaths.leftArrow);
        public string[] rightArrow = Reader.readFromFile(ConstPaths.rightArrow);
        public string[] Z = Reader.readFromFile(ConstPaths.Z);
        public string[] X = Reader.readFromFile(ConstPaths.X);
        public string[] moveLeft = Reader.readFromFile(ConstPaths.moveLeft);
        public string[] moveRight = Reader.readFromFile(ConstPaths.moveRight);
        public string[] moveUp = Reader.readFromFile(ConstPaths.moveUp);
        public string[] moveDown = Reader.readFromFile(ConstPaths.moveDown);
        public string[] back = Reader.readFromFile(ConstPaths.back);
        public string[] choose = Reader.readFromFile(ConstPaths.choose);
        public string[] easy = Reader.readFromFile(ConstPaths.easy);
        public string[] medium = Reader.readFromFile(ConstPaths.medium);
        public string[] hard = Reader.readFromFile(ConstPaths.hard);

        public List<rankingModel> easyRank = rankingController.getRanking(ConstPaths.easyRank);
        public List<rankingModel> mediumRank = rankingController.getRanking(ConstPaths.mediumRank);
        public List<rankingModel> hardRank = rankingController.getRanking(ConstPaths.hardRank);

        public GameController game;

        public Position lPlay;
        public Position rPlay;
        public Position lRanking;
        public Position rRanking;
        public Position lControls;
        public Position rControls;
        public Position lExit;
        public Position rExit;

        public Position lEasy;
        public Position rEasy;
        public Position lMedium;
        public Position rMedium;
        public Position lHard;
        public Position rHard;

        public void startMenu()
        {
            Console.WindowWidth = 144;
            Console.WindowHeight = 50;
            Console.CursorVisible = false;
            printMenu();
            startGamePlayer.Play();
            while (!menuExitFlag2)
            {
                handleMenuInput();
            }
            menuExitFlag2 = false;
        }

        public void handleMenuInput()
        {
            var status = InputPicker.getInput();
            if (status != null)
            {
                switch (status.InputPossibilities)
                {
                    case InputPossibilities.UP:
                        if (currPositionMenu > 0)
                        {
                            printArrowsMenu(currPositionMenu, false);
                            currPositionMenu--;
                            printArrowsMenu(currPositionMenu, true);
                            changePositionPlayer.Play();
                        }
                        break;
                    case InputPossibilities.DOWN:
                        if (currPositionMenu < menuPositionLimit)
                        {
                            printArrowsMenu(currPositionMenu, false);
                            currPositionMenu++;
                            printArrowsMenu(currPositionMenu, true);
                            changePositionPlayer.Play();
                        }
                        break;
                    case InputPossibilities.ENTER:
                        switch (currPositionMenu)
                        {
                            case 0:
                                Console.Clear();
                                printDifficulty();
                                changeMenuPlayer.Play();
                                while (!menuExitFlag)
                                {
                                    handleDifficultyInput();
                                }
                                menuExitFlag = false;
                                menuExitFlag2 = true;
                                break;
                            case 1:
                                printRank();
                                printMenu();
                                break;
                            case 2:
                                printControls();
                                printMenu();
                                break;
                            case 3:
                                rankingController.saveRankingToFile(easyRank, ConstPaths.easyRank);
                                rankingController.saveRankingToFile(mediumRank, ConstPaths.mediumRank);
                                rankingController.saveRankingToFile(hardRank, ConstPaths.hardRank);
                                Console.Clear();
                                printStringArr(exitMsg, new Position(0, 10));
                                Thread.Sleep(1000);
                                Environment.Exit(0);
                                break;
                        };
                        break;
                }
            }
        }

        public void handleDifficultyInput()
        {
            var status = InputPicker.getInput();
            if (status != null)
            {
                switch (status.InputPossibilities)
                {
                    case InputPossibilities.UP:
                        if (currPositionDifficulty > 0)
                        {
                            printArrowsDifficulty(currPositionDifficulty, false);
                            currPositionDifficulty--;
                            printArrowsDifficulty(currPositionDifficulty, true);
                            changePositionPlayer.Play();
                        }
                        break;
                    case InputPossibilities.DOWN:
                        if (currPositionDifficulty < difficultyPositionLimit)
                        {
                            printArrowsDifficulty(currPositionDifficulty, false);
                            currPositionDifficulty++;
                            printArrowsDifficulty(currPositionDifficulty, true);
                            changePositionPlayer.Play();
                        }
                        break;
                    case InputPossibilities.ENTER:
                        GlobalAccessClass.diffLevel = currPositionDifficulty;
                        game = new GameController(currPositionDifficulty);
                        Console.Clear();
                        GlobalAccessClass.isFinished = false;
                        var stopwatchController = new StopwatchController();
                        Thread thread = new Thread(stopwatchController.threadTimer);
                        Console.WindowHeight = 50;
                        Console.WindowWidth = 106;
                        game.MapController.renderGrid(game.grid, game.sidelength);
                        thread.Start();
                        while (!game.endFlag)
                        {
                            game.handleInput();
                        }
                        game.endFlag = false;
                        menuExitFlag = true;
                        if (GlobalAccessClass.isWin)
                        {
                            switch (GlobalAccessClass.diffLevel)
                            {
                                case 0:
                                    var item = easyRank.Find(x => x.nick == GlobalAccessClass.nick);
                                    if (item == null)
                                        easyRank.Add(new rankingModel(GlobalAccessClass.nick, GlobalAccessClass.time, GlobalAccessClass.ms));
                                    else
                                    {
                                        item.ms = GlobalAccessClass.ms;
                                        item.time = GlobalAccessClass.time;
                                    }
                                    break;
                                case 1:
                                    var item2 = mediumRank.Find(x => x.nick == GlobalAccessClass.nick);
                                    if (item2 == null)
                                        mediumRank.Add(new rankingModel(GlobalAccessClass.nick, GlobalAccessClass.time, GlobalAccessClass.ms));
                                    else
                                    {
                                        item2.ms = GlobalAccessClass.ms;
                                        item2.time = GlobalAccessClass.time;
                                    }
                                    break;
                                case 2:
                                    var item3 = hardRank.Find(x => x.nick == GlobalAccessClass.nick);
                                    if (item3 == null)
                                        hardRank.Add(new rankingModel(GlobalAccessClass.nick, GlobalAccessClass.time, GlobalAccessClass.ms));
                                    else
                                    {
                                        item3.ms = GlobalAccessClass.ms;
                                        item3.time = GlobalAccessClass.time;
                                    }
                                    break;
                            }
                        }
                        GlobalAccessClass.isWin = false;
                        break;
                }
            }
        }

        public void printDifficulty()
        {
            printStringArr(choose, new Position(20, 3));
            lEasy = new Position(37, Console.CursorTop + 7);
            rEasy = new Position(81, Console.CursorTop + 7);
            printStringArr(easy, new Position(50, Console.CursorTop + 7));
            lMedium = new Position(32, Console.CursorTop + 3);
            rMedium = new Position(87, Console.CursorTop + 3);
            printStringArr(medium, new Position(45, Console.CursorTop + 3));
            lHard = new Position(37, Console.CursorTop + 3);
            rHard = new Position(79, Console.CursorTop + 3);
            printStringArr(hard, new Position(50, Console.CursorTop + 3));
            printArrowsDifficulty(currPositionDifficulty, true);
        }

        public void printMenu()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            int i = 0;
            Console.SetCursorPosition(15, i);
            foreach (string s in title)
            {
                Console.Write(s);
                i++;
                Console.SetCursorPosition(15, i);
            }
            i += 5;
            Console.SetCursorPosition(50, i);
            lPlay = new Position(38, i);
            rPlay = new Position(50 + play[0].Length + 2, i);
            foreach (string s in play)
            {
                Console.Write(s);
                i++;
                Console.SetCursorPosition(50, i);
            }
            i += 2;
            Console.SetCursorPosition(42, i);
            lRanking = new Position(30, i);
            rRanking = new Position(42 + ranking[0].Length + 2, i);
            foreach (string s in ranking)
            {
                Console.Write(s);
                i++;
                Console.SetCursorPosition(42, i);
            }
            i += 2;
            Console.SetCursorPosition(40, i);
            lControls = new Position(28, i);
            rControls = new Position(40 + controls[0].Length + 2, i);
            foreach (string s in controls)
            {
                Console.Write(s);
                i++;
                Console.SetCursorPosition(40, i);
            }
            i += 2;
            Console.SetCursorPosition(52, i);
            lExit = new Position(40, i);
            rExit = new Position(52 + exit[0].Length + 2, i);
            foreach (string s in exit)
            {
                Console.Write(s);
                i++;
                Console.SetCursorPosition(52, i);
            }
            printArrowsMenu(currPositionMenu, true);
        }

        public void printControls()
        {
            Console.Clear();

            printStringArr(moveUp, new Position(20, 0));
            printStringArr(moveDown, new Position(20, Console.CursorTop + 3));
            printStringArr(moveLeft, new Position(20, Console.CursorTop + 3));
            printStringArr(moveRight, new Position(20, Console.CursorTop + 3));

            printStringArr(Z, new Position(30, Console.CursorTop + 7));
            printStringArr(X, new Position(30, Console.CursorTop + 3));

            Console.ForegroundColor = ConsoleColor.DarkRed;
            printStringArr(back, new Position(111, 0));
            Console.ForegroundColor = PixelColours.basicTextColour;
            changeMenuPlayer.Play();
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) ;

            Console.Clear();
        }

        public void printArrowsMenu(int postion, bool op)
        {
            if (op)
            {
                Console.ForegroundColor = PixelColours.basicTextColour;
            }
            else
            {
                Console.ForegroundColor = PixelColours.envColor;
            }

            switch (postion)
            {
                case 0:
                    printStringArr(rightArrow, new Position(lPlay.x, lPlay.y));
                    printStringArr(leftArrow, new Position(rPlay.x, rPlay.y));
                    break;
                case 1:
                    printStringArr(rightArrow, new Position(lRanking.x, lRanking.y));
                    printStringArr(leftArrow, new Position(rRanking.x, rRanking.y));
                    break;
                case 2:
                    printStringArr(rightArrow, new Position(lControls.x, lControls.y));
                    printStringArr(leftArrow, new Position(rControls.x, rControls.y));
                    break;
                case 3:
                    printStringArr(rightArrow, new Position(lExit.x, lExit.y));
                    printStringArr(leftArrow, new Position(rExit.x, rExit.y));
                    break;
            }
        }
        public void printArrowsDifficulty(int postion, bool op)
        {
            if (op)
            {
                Console.ForegroundColor = PixelColours.basicTextColour;
            }
            else
            {
                Console.ForegroundColor = PixelColours.envColor;
            }

            switch (postion)
            {
                case 0:
                    printStringArr(rightArrow, new Position(lEasy.x, lEasy.y));
                    printStringArr(leftArrow, new Position(rEasy.x, rEasy.y));
                    break;
                case 1:
                    printStringArr(rightArrow, new Position(lMedium.x, lMedium.y));
                    printStringArr(leftArrow, new Position(rMedium.x, rMedium.y));
                    break;
                case 2:
                    printStringArr(rightArrow, new Position(lHard.x, lHard.y));
                    printStringArr(leftArrow, new Position(rHard.x, rHard.y));
                    break;
            }
        }

        public void printRank()
        {
            Console.Clear();
            printStringArr(easy, new Position(10, 10));
            rankingController.printRanking(easyRank, new Position(16, Console.CursorTop + 3));
            printStringArr(medium, new Position(52, 10));
            rankingController.printRanking(mediumRank, new Position(65, Console.CursorTop + 3));
            printStringArr(hard, new Position(102, 10));
            rankingController.printRanking(hardRank, new Position(108, Console.CursorTop + 3));
            Console.ForegroundColor = ConsoleColor.DarkRed;
            printStringArr(back, new Position(101, 0));
            Console.ForegroundColor = PixelColours.envColor;
            changeMenuPlayer.Play();
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) ;
        }

        public void printStringArr(string[] arr, Position position)
        {
            Console.SetCursorPosition(position.x, position.y);
            int i = position.y;
            foreach (string s in arr)
            {
                Console.Write(s);
                i++;
                Console.SetCursorPosition(position.x, i);
            }
        }
 
    }
}
