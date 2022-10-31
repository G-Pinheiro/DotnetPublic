// Tic Tac Toe (Jogo da Velha)
using BoardLogic;
Board game = new Board();

// Program Core
game.PrintBoard(game.Grid);
while (true)
{
    game.PlayerTurn(game.Grid);

    if (game.CheckMoves(game.Grid) == false)
    {
        break;
    }
    else if (game.AvailableMoves(game.Grid) == false)
    {
        break;
    }

    game.PcTurn(game.Grid);

    if (game.CheckMoves(game.Grid) == false)
    {
        break;
    }
    else if (game.AvailableMoves(game.Grid) == false)
    {
        break;
    }

    game.PrintBoard(game.Grid);
}

game.PrintBoard(game.Grid);
Console.WriteLine();
Console.WriteLine("Press any key to close the game...");
Console.ReadLine();

