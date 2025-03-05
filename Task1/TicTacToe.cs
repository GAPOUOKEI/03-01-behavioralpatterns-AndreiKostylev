using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class TicTacToe : TurnBasedGame
    {
        private char[,] board;
        private char currentPlayer;

        public TicTacToe(string player1, string player2) : base(player1, player2)
        {
            board = new char[3, 3];
            currentPlayer = 'X';
        }

        public override void InitializeGame()
        {
            Console.WriteLine("Игра \"Крестики-нолики\" началась!");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = '-';
                }
            }
        }

        public override void ExecuteTurn()
        {
            Console.WriteLine($"Ход игрока {currentPlayer}");
            DisplayBoard();
            Console.Write("Введите строку (0-2): ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Введите столбец (0-2): ");
            int col = int.Parse(Console.ReadLine());

            if (board[row, col] == '-')
            {
                board[row, col] = currentPlayer;
                currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
                Turns++;
            }
            else
            {
                Console.WriteLine("Клетка занята, попробуйте снова.");
            }
        }

        public override bool IsGameOver()
        {
            return CheckWin() || Turns >= 9;
        }

        public override void EndGame()
        {
            DisplayBoard();
            if (CheckWin())
            {
                char winner = (currentPlayer == 'X') ? 'O' : 'X';
                Console.WriteLine($"Игрок {winner} победил!");
            }
            else
            {
                Console.WriteLine("Ничья!");
            }
        }

        private void DisplayBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private bool CheckWin()
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] != '-' && board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2]) return true;
                if (board[0, i] != '-' && board[0, i] == board[1, i] && board[1, i] == board[2, i]) return true;
            }
            if (board[0, 0] != '-' && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2]) return true;
            if (board[0, 2] != '-' && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0]) return true;
            return false;
        }
    }
}
