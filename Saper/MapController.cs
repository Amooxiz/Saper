using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saper
{
    internal class MapController
    {
        public List<char>[,] createGrid(int sideLength, int mineAmount)
        {
            List<char>[,] grid = new List<char>[sideLength, sideLength];
            List<Position> allPossiblePositions = new();
            int mineCounter = mineAmount;
            for (int i = 0; i < sideLength; i++)
            {
                for (int j = 0; j < sideLength; j++)
                {
                    allPossiblePositions.Add(new Position(i, j));
                    grid[i, j] = new List<char>();
                }
            }
            Random random = new Random();
            var mineLocations = allPossiblePositions.OrderBy(x => random.Next()).Take(mineAmount);
            foreach(Position position in mineLocations)
            {
                grid[position.x, position.y].Add(ConstantEnviromentElements.mineField);
            }
            this.calculateFields(grid, sideLength);
            return grid;
        }

        public void renderGrid(List<char>[,] grid, int sideLength)
        {
            for(int i = 0; i < sideLength;i++)
            {
                for(int j = 0; j < sideLength; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        Console.SetCursorPosition(0, 0);
                        Console.BackgroundColor = PixelColours.playerPosition;
                        Console.Write(grid[0, 0].Last());
                        Console.BackgroundColor = PixelColours.envColor;
                        continue;
                    }
                    Console.Write(grid[i,j].Last());
                }
                Console.WriteLine();
            }
        }

        private void calculateFields(List<char>[,] grid, int sideLenght)
        {
            for (int i = 0; i < sideLenght; i++)
            {
                for (int j = 0; j < sideLenght; j++)
                {
                    if (grid[i, j].Count > 0)
                    {
                        grid[i, j].Add(ConstantEnviromentElements.unexploredField);
                        continue;
                    }

                    int sum = 0;
                    if (i - 1 >= 0 && grid[i - 1, j].Count > 0)
                    {
                        if (grid[i - 1, j].LastOrDefault() == ConstantEnviromentElements.mineField)
                            sum++;
                    }
                    if (i + 1 < sideLenght && grid[i + 1, j].Count > 0)
                    {
                        if (grid[i + 1, j].LastOrDefault() == ConstantEnviromentElements.mineField)
                            sum++;
                    }
                    if (j - 1 >= 0 && grid[i, j - 1].Count > 0)
                    {
                         if (grid[i, j - 1].LastOrDefault() == ConstantEnviromentElements.mineField)
                            sum++;
                    }
                    if (j + 1 < sideLenght && grid[i, j + 1].Count > 0)
                    {
                        if (grid[i, j + 1].LastOrDefault() == ConstantEnviromentElements.mineField)
                            sum++;
                    }
                    if ((i - 1 >= 0 && j - 1 >= 0) && grid[i - 1, j - 1].Count > 0)
                    {
                        if (grid[i - 1, j - 1].LastOrDefault() == ConstantEnviromentElements.mineField)
                            sum++;
                    }
                    if ((i + 1 < sideLenght && j + 1 < sideLenght) && grid[i + 1, j + 1].Count > 0)
                    {
                        if (grid[i + 1, j + 1].LastOrDefault() == ConstantEnviromentElements.mineField)
                            sum++;
                    }
                    if ((i - 1 >= 0 && j + 1 < sideLenght) && grid[i - 1, j + 1].Count > 0)
                    {
                        if (grid[i - 1, j + 1].LastOrDefault() == ConstantEnviromentElements.mineField)
                            sum++;
                    }
                    if ((i + 1 < sideLenght && j - 1 >= 0) && grid[i + 1, j - 1].Count > 0)
                    {
                        if (grid[i + 1, j - 1].LastOrDefault() == ConstantEnviromentElements.mineField)
                            sum++;
                    }

                    switch (sum)
                    {
                        case 0:
                            grid[i, j].Add(ConstantEnviromentElements.emptyField);
                            break;
                        case 1:
                            grid[i, j].Add(ConstantEnviromentElements.one);
                            break;
                        case 2:
                            grid[i, j].Add(ConstantEnviromentElements.two);
                            break;
                        case 3:
                            grid[i, j].Add(ConstantEnviromentElements.three);
                            break;
                        case 4:
                            grid[i, j].Add(ConstantEnviromentElements.four);
                            break;
                        case 5:
                            grid[i, j].Add(ConstantEnviromentElements.five);
                            break;
                        case 6:
                            grid[i, j].Add(ConstantEnviromentElements.six);
                            break;
                        case 7:
                            grid[i, j].Add(ConstantEnviromentElements.seven);
                            break;
                        case 8:
                            grid[i, j].Add(ConstantEnviromentElements.eight);
                            break;
                        default:
                            break;
                    }
                    grid[i, j].Add(ConstantEnviromentElements.unexploredField);
                }
            }
        }
    }
}
