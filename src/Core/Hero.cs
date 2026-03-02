using System;
using System.Collections.Generic;
using System.Text;
using AdventureLogic.src.Enums;

namespace AdventureLogic.src.Core
{
    public class Hero
    {

        private string _heroName;
        private State _currentState;

        public Hero(string name, State state)
        {
            _heroName = name;
            _currentState = state;
        }

        public void StateLog()
        {
            Console.WriteLine($"Der Held ist in dem State: {_currentState}");
        }
        public void ChangeState(State newState)
        {
            if(_currentState == newState)
            {
                Console.WriteLine($"{_heroName} ist bereits in dieser State ({_currentState})");
                return;
            }
                Console.WriteLine($"{_heroName} hat von {_currentState} zu {newState} gewechselt.");
                _currentState = newState;
        }

    }
}
