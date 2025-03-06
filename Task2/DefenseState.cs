using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class DefenseState : ICharacterState
    {
        public void HandleAction(Character character)
        {
            Console.WriteLine($"{character.Name} поднимает щит и защищается!");
        }
    }
}
