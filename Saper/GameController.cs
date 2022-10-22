using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saper
{
    internal class GameController
    {
        public MapController MapController = new MapController();
        public Player player = new Player();
        public int sidelength = new int();
        public int mineCount = new int();
        public List<char>[,] grid;

        public GameController(int sideLength, int mineCount)
        {
            this.sidelength = sideLength;
            this.mineCount = mineCount;
            grid = MapController.createGrid(sideLength, mineCount);
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
                }
            }
        }

        private void moveDown()
        {
            Console.SetCursorPosition(this.player._position.x, this.player._position.y);
            Console.BackgroundColor = PixelColours.envColor;
            Console.Write(grid[this.player._position.x, this.player._position.y].Last());

            player.changePosition(this.player._position.x, this.player._position.y + 1);

            Console.SetCursorPosition(this.player._position.x, this.player._position.y);
            Console.BackgroundColor = PixelColours.playerPosition;
            Console.Write(grid[this.player._position.x, this.player._position.y].Last());
        }

        private void moveUp()
        {
            Console.SetCursorPosition(this.player._position.x, this.player._position.y);
            Console.BackgroundColor = PixelColours.envColor;
            Console.Write(grid[this.player._position.x, this.player._position.y].Last());

            player.changePosition(this.player._position.x, this.player._position.y - 1);

            Console.SetCursorPosition(this.player._position.x, this.player._position.y);
            Console.BackgroundColor = PixelColours.playerPosition;
            Console.Write(grid[this.player._position.x, this.player._position.y].Last());
        }

        private void moveRight()
        {
            Console.SetCursorPosition(this.player._position.x, this.player._position.y);
            Console.BackgroundColor = PixelColours.envColor;
            Console.Write(grid[this.player._position.x, this.player._position.y].Last());

            player.changePosition(this.player._position.x + 1, this.player._position.y);

            Console.SetCursorPosition(this.player._position.x, this.player._position.y);
            Console.BackgroundColor = PixelColours.playerPosition;
            Console.Write(grid[this.player._position.x, this.player._position.y].Last());
        }

        private void moveLeft()
        {
            Console.SetCursorPosition(this.player._position.x, this.player._position.y);
            Console.BackgroundColor = PixelColours.envColor;
            Console.Write(grid[this.player._position.x, this.player._position.y].Last());

            player.changePosition(this.player._position.x - 1, this.player._position.y);

            Console.SetCursorPosition(this.player._position.x, this.player._position.y);
            Console.BackgroundColor = PixelColours.playerPosition;
            Console.Write(grid[this.player._position.x, this.player._position.y].Last());
        }
    }
}
