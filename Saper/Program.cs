// See https://aka.ms/new-console-template for more information
using Saper;

GameController gameController = new GameController(50, 200);
gameController.MapController.renderGrid(gameController.grid, gameController.sidelength);
while (true)
{
    gameController.handleInput();
}
