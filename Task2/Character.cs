using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Character
    {
        private ICharacterState currentState;
        public string Name { get; set; }

        public Character(string name)
        {
            Name = name;
            currentState = new NormalState(); // Начальное состояние – обычное
        }

        public void SetState(ICharacterState state)
        {
            currentState = state;
        }

        public void PerformAction()
        {
            currentState.HandleAction(this);
        }
    }
}
