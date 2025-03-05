using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class NormalState : ICharacterState
    {
        public void HandleAction(Character character)
        {
            Console.WriteLine($"{character.Name} стоит и осматривается.");
        }

    }
}
