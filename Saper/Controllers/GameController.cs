using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Saper
{
    internal class GameController
    {
        public SoundPlayer winPlayer = new SoundPlayer(Path.GetFullPath(ConstPaths.winSound));
        public SoundPlayer loosePlayer = new SoundPlayer(Path.GetFullPath(ConstPaths.explosionSound));
        public SoundPlayer uncoverRecPlayer = new SoundPlayer(Path.GetFullPath(ConstPaths.uncoverRecSound));
        public SoundPlayer movePlayer = new SoundPlayer(Path.GetFullPath(ConstPaths.moveSound));
        public SoundPlayer markPlayer = new SoundPlayer(Path.GetFullPath(ConstPaths.markSound));

        public MapController MapController = new MapController();
        public Player player = new Player();
        public int sidelength = new int();
        public int mineCount = new int();
        public List<char>[,] grid;
        public int openedPoolsCounter = 0;
        public int mineSecuredCounter = 0;
        public int openedPoolsLimit = new int();
        public int easyLevelMineAmount = 10;
        public int mediumLevelMineAmount = 30;
        public int hardLevelMineAmount = 60;

        public string[] gameOverr = Reader.readFromFile(ConstPaths.gameOver);
        public string[] back = Reader.readFromFile(ConstPaths.back);
        public string[] expolosion = Reader.readFromFile(ConstPaths.explosion);
        public string[] winn = Reader.readFromFile(ConstPaths.win);

        public bool endFlag = false;

        public GameController(int diffLevel)
        {
            switch (diffLevel)
            {
                case 0:
                    mineCount = easyLevelMineAmount;
                    break;
                case 1:
                    mineCount = mediumLevelMineAmount;
                    break;
                case 2:
                    mineCount = hardLevelMineAmount;
                    break;
            }
            this.sidelength = 18;
            this.openedPoolsLimit = 18 * 18 - mineCount;
            
            grid = MapController.createGrid(18, mineCount);
        }
        public void handleInput()
        {
            var status = InputPicker.getInput();
            if (status != null)
            {
                switch (status.InputPossibilities)
                {
                    case InputPossibilities.LEFT:
                        if (player._position.x > 0)
                            this.moveLeft();
                        break;
                    case InputPossibilities.RIGHT:
                        if (player._position.x < sidelength - 1)
                            this.moveRight();
                        break;
                    case InputPossibilities.UP:
                        if (player._position.y > 0)
                            this.moveUp();
                        break;
                    case InputPossibilities.DOWN:
                        if (player._position.y < sidelength - 1)
                            this.moveDown();
                        break;
                    case InputPossibilities.MARK:
                        this.mark();
                        if (mineSecuredCounter == mineCount && openedPoolsCounter == openedPoolsLimit)
                            this.win();
                        break;
                    case InputPossibilities.UNCOVER:
                        this.uncover();
                        if (mineSecuredCounter == mineCount && openedPoolsCounter == openedPoolsLimit)
                            this.win();
                        break;
                }
            }
        }

        private void moveDown()
        {
            printChar(grid[this.player._position.y, this.player._position.x].Last(), PixelColours.envColor,
                new Position(this.player._position.x + (this.player._position.x * 3) + 17, (this.player._position.y * 2) + 14));

            player.changePosition(this.player._position.x, this.player._position.y + 1);

            printChar(grid[this.player._position.y, this.player._position.x].Last(), PixelColours.playerPosition,
                new Position(this.player._position.x + (this.player._position.x * 3) + 17, (this.player._position.y * 2) + 14));
            movePlayer.Play();
        }

        private void moveUp()
        {
            printChar(grid[this.player._position.y, this.player._position.x].Last(), PixelColours.envColor,
                new Position(this.player._position.x + (this.player._position.x * 3) + 17, (this.player._position.y * 2) + 14));

            player.changePosition(this.player._position.x, this.player._position.y - 1);

            printChar(grid[this.player._position.y, this.player._position.x].Last(), PixelColours.playerPosition,
                new Position(this.player._position.x + (this.player._position.x * 3) + 17, (this.player._position.y * 2) + 14));
            movePlayer.Play();
        }

        private void moveRight()
        {
            printChar(grid[this.player._position.y, this.player._position.x].Last(), PixelColours.envColor,
                new Position(this.player._position.x + (this.player._position.x * 3) + 17, (this.player._position.y * 2) + 14));

            player.changePosition(this.player._position.x + 1, this.player._position.y);

            printChar(grid[this.player._position.y, this.player._position.x].Last(), PixelColours.playerPosition,
                new Position(this.player._position.x + (this.player._position.x * 3) + 17, (this.player._position.y * 2) + 14));
            movePlayer.Play();
        }

        private void moveLeft()
        {
            printChar(grid[this.player._position.y, this.player._position.x].Last(), PixelColours.envColor,
                new Position(this.player._position.x + (this.player._position.x * 3) + 17, (this.player._position.y * 2) + 14));

            player.changePosition(this.player._position.x - 1, this.player._position.y);

            printChar(grid[this.player._position.y, this.player._position.x].Last(), PixelColours.playerPosition,
                new Position(this.player._position.x + (this.player._position.x * 3) + 17, (this.player._position.y * 2) + 14));
            movePlayer.Play();
        }

        private void mark()
        {
            if (grid[player._position.y, player._position.x].Last() == ConstantEnviromentElements.unexploredField)
            {
                grid[player._position.y, player._position.x].Add(ConstantEnviromentElements.mineMarkedField);
                mineSecuredCounter++;

                printChar(ConstantEnviromentElements.mineMarkedField, PixelColours.playerPosition,
                    new Position(this.player._position.x + (this.player._position.x * 3) + 17, (this.player._position.y * 2) + 14));
                markPlayer.Play();
            }
            else if (grid[player._position.y, player._position.x].Last() == ConstantEnviromentElements.mineMarkedField)
            {
                grid[player._position.y, player._position.x].RemoveAt(grid[player._position.y, player._position.x].Count - 1);
                mineSecuredCounter--;

                printChar(ConstantEnviromentElements.unexploredField, PixelColours.playerPosition,
                    new Position(this.player._position.x + (this.player._position.x * 3) + 17, (this.player._position.y * 2) + 14));
            }
        }

        private void win()
        {
            GlobalAccessClass.isFinished = true;
            Console.BackgroundColor = PixelColours.envColor;
            Console.Clear();
            Console.SetCursorPosition(35, 15);
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (string s in winn)
            {
                Console.Write(s);
                Console.SetCursorPosition(35, Console.CursorTop + 1);
            }
            Console.SetCursorPosition(51, Console.CursorTop + 4);
            Console.ForegroundColor = PixelColours.basicTextColour;
            Console.Write("Time:");
            Console.SetCursorPosition(52, Console.CursorTop + 2);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"{GlobalAccessClass.minutes}:{GlobalAccessClass.seconds}");
            Console.SetCursorPosition(73, 0);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            foreach (string s in back)
            {
                Console.Write(s);
                Console.SetCursorPosition(73, Console.CursorTop + 1);
            }
            Console.ForegroundColor = PixelColours.basicTextColour;
            winPlayer.Play();
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) ;
            this.endFlag = true;
            GlobalAccessClass.isWin = true;
        }

        private void uncover()
        {
            if (grid[player._position.y, player._position.x].Last() == ConstantEnviromentElements.unexploredField)
            {
                switch (grid[player._position.y, player._position.x].ElementAt(grid[player._position.y, player._position.x].Count - 2))
                {
                    case ConstantEnviromentElements.mineField:
                        gameOver();
                        break;
                    case ConstantEnviromentElements.emptyField:
                        lock (CursorLock.Lock)
                            uncoverRec(player._position);
                        uncoverRecPlayer.Play();
                        break;
                    default: // number Field
                        uncover(player._position);
                        break;
                }
            }
        }

        private void uncover(Position position)
        {
            grid[position.y, position.x].RemoveAt(grid[position.y, position.x].Count - 1);
            openedPoolsCounter++;
            printChar(grid[position.y, position.x].Last(), PixelColours.playerPosition,
                new Position(position.x + (position.x * 3) + 17, (position.y * 2) + 14));
        }

        private void uncoverRec(Position position)
        {
            grid[position.y, position.x].RemoveAt(grid[position.y, position.x].Count - 1);
            openedPoolsCounter++;

            if (position.x == player._position.x && position.y == player._position.y)
            {

                printChar(grid[position.y, position.x].Last(), PixelColours.playerPosition,
                    new Position(position.x + (position.x * 3) + 17, (position.y * 2) + 14));
            }
            else if (grid[position.y, position.x].Count > 0)
            {

                printChar(grid[position.y, position.x].Last(), PixelColours.envColor,
                    new Position(position.x + (position.x * 3) + 17, (position.y * 2) + 14));
            }

            if (grid[position.y, position.x].LastOrDefault() != ConstantEnviromentElements.emptyField)
                return;

            if (position.y > 0 && grid[position.y - 1, position.x].Contains(ConstantEnviromentElements.unexploredField))
                uncoverRec(new Position(position.x, position.y - 1));
            if (position.y < sidelength - 1 && grid[position.y + 1, position.x].Contains(ConstantEnviromentElements.unexploredField))
                uncoverRec(new Position(position.x, position.y + 1));
            if (position.y > 0 && position.x < sidelength - 1 && grid[position.y - 1, position.x + 1].Contains(ConstantEnviromentElements.unexploredField))
                uncoverRec(new Position(position.x + 1, position.y - 1));
            if (position.y < sidelength - 1 && position.x > 0 && grid[position.y + 1, position.x - 1].Contains(ConstantEnviromentElements.unexploredField))
                uncoverRec(new Position(position.x - 1, position.y + 1));
            if (position.x < sidelength - 1 && grid[position.y, position.x + 1].Contains(ConstantEnviromentElements.unexploredField))
                uncoverRec(new Position(position.x + 1, position.y));
            if (position.x > 0 && grid[position.y, position.x - 1].Contains(ConstantEnviromentElements.unexploredField))
                uncoverRec(new Position(position.x - 1, position.y));
            if (position.y > 0 && position.x > 0 && grid[position.y - 1, position.x - 1].Contains(ConstantEnviromentElements.unexploredField))
                uncoverRec(new Position(position.x - 1, position.y - 1));
            if (position.y < sidelength - 1 && position.x < sidelength - 1 && grid[position.y + 1, position.x + 1].Contains(ConstantEnviromentElements.unexploredField))
                uncoverRec(new Position(position.x + 1, position.y + 1));

            return;

        }

        private void printChar(char ch, ConsoleColor consoleColor, Position position)
        {
            lock (CursorLock.Lock)
            {
                Console.SetCursorPosition(position.x, position.y);
                Console.BackgroundColor = consoleColor;
                Console.Write(ch);
            }
        }

        private void gameOver()
        {
            GlobalAccessClass.isFinished = true;
            Console.BackgroundColor = PixelColours.envColor;
            Console.Clear();
            Console.SetCursorPosition(22, 15);
            Console.ForegroundColor = ConsoleColor.Red;
            foreach (string s in gameOverr)
            {
                Console.Write(s);
                Console.SetCursorPosition(22, Console.CursorTop + 1);
            }
            Console.SetCursorPosition(38, Console.CursorTop + 8);
            Console.ForegroundColor = PixelColours.basicTextColour;
            foreach (string s in expolosion)
            {
                Console.Write(s);
                Console.SetCursorPosition(38, Console.CursorTop + 1);
            }
            Console.SetCursorPosition(73, 0);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            foreach (string s in back)
            {
                Console.Write(s);
                Console.SetCursorPosition(73, Console.CursorTop + 1);
            }
            Console.ForegroundColor = PixelColours.basicTextColour;
            loosePlayer.Play();
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) ;
            this.endFlag = true;
        }
    }
}
