using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Game
    {
        private List<string> moves = new List<string>();
        public int Turn { get; private set; } = 1;

        public void MakeMove(string move)
        {
            moves.Add($"Ход {Turn}: {move}");
            Console.WriteLine($"Выполнен ход {Turn}: {move}");
            Turn++;
        }

        public void UndoMove()
        {
            if (moves.Count > 0)
            {
                string lastMove = moves[^1];
                moves.RemoveAt(moves.Count - 1);
                Turn--;
                Console.WriteLine($"Отменён {lastMove}");
            }
            else
            {
                Console.WriteLine("Нет ходов для отмены.");
            }
        }

        public void ShowMoves()
        {
            Console.WriteLine("\nИстория ходов:");
            if (moves.Count == 0)
                Console.WriteLine("Пока нет ходов.");
            else
                moves.ForEach(Console.WriteLine);
        }
    }
}
