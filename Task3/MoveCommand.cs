using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class MoveCommand : ICommand
    {
        private Game game;
        private string move;

        public MoveCommand(Game game, string move)
        {
            this.game = game;
            this.move = move;
        }

        public void Execute()
        {
            game.MakeMove(move);
        }

        public void Undo()
        {
            game.UndoMove();
        }
    }
}
