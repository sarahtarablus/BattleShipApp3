using System;

namespace BattleShipApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            GameGrid grid = new GameGrid();
            grid.getGrid();

            PlayGame play = new PlayGame();
            play.play();

        }
    }
}
