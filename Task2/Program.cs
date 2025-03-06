namespace Task2
{
    /*
     * ФИО студента: Костылев Андрей
     * номер варианта: 7
     * условие задачи (скопировать из листа задания): Создайте класс персонажа, который может иметь различные состояния (например, нормальное состояние, атака, защита). 
     * Логика поведения должна изменяться в зависимости от текущего состояния
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Character hero = new Character("Герой");

            // Начальное состояние (нормальное)
            hero.PerformAction();

            // Переключаемся в атаку
            hero.SetState(new AttackState());
            hero.PerformAction();

            // Переключаемся в защиту
            hero.SetState(new DefenseState());
            hero.PerformAction();

            // Возвращаемся в нормальное состояние
            hero.SetState(new NormalState());
            hero.PerformAction();
        }
    }
}
