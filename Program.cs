using System;

namespace SnakeLadderGame
{
    class Program
    {
        static void Main(string[] args)
        {
            StartPosition.Start();
            PlayerRollsDie.DieRoll();
            CheckOption.OptionToPlay();
            PlayTillWin.PlayToWin();
            WinningPosition.PositionToWin();
            DierollCount.TotalDieCount();
            TwoPlayer.PlayTwoPlayer();

        }
    }
}
