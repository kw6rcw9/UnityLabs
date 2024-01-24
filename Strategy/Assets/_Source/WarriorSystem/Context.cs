using UnityEngine;

namespace WarriorSystem
{
    public class Context: IContext
    {
        private IAttackStrategy _strategy;

        public Context(IAttackStrategy strategy)
        {
            _strategy = strategy;
        }
        public void SetStrategy(IAttackStrategy newStrat)
        {
            _strategy = newStrat;
        }

        public void PerfomAttack(Animator animator)
        {
            if(_strategy != null)
                _strategy.Attack(animator);
        }
    }
}
