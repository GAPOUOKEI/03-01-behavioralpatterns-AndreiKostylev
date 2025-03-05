using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal abstract class TurnBasedGame
    {
        public string Player1 { get; set; }
        public string Player2 { get; set; }
        public int Turns { get; set; }

        public TurnBasedGame(string player1, string player2)
        {
            Player1 = player1;
            Player2 = player2;
            Turns = 0;
        }

        public abstract void InitializeGame();
        public abstract void ExecuteTurn();
        public abstract bool IsGameOver();
        public abstract void EndGame();

        public void PlayGame()
        {
            InitializeGame();
            while (!IsGameOver())
            {
                ExecuteTurn();
            }
            EndGame();
        }
    }
}
