namespace Task3
{
    /*
     * ФИО студента: Костылев Андрей
     * номер варианта: 7
     * условие задачи (скопировать из листа задания): Разработайте простую настольную игру с командами для выполнения ходов, 
     * отмены предыдущего хода и отмены действий.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            GameInvoker invoker = new GameInvoker();

            while (true)
            {
                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("1 - Сделать ход");
                Console.WriteLine("2 - Отменить последний ход");
                Console.WriteLine("3 - Показать историю ходов");
                Console.WriteLine("0 - Выйти");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Введите описание хода: ");
                        string move = Console.ReadLine();
                        ICommand command = new MoveCommand(game, move);
                        invoker.ExecuteCommand(command);
                        break;

                    case "2":
                        invoker.UndoLastCommand();
                        break;

                    case "3":
                        game.ShowMoves();
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Некорректный ввод. Попробуйте снова.");
                        break;
                }
            }
        }
    }
}

