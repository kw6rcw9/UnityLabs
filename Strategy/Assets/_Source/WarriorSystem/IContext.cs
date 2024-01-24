using UnityEngine;

namespace WarriorSystem
{
    public interface IContext
    {
        void SetStrategy(IAttackStrategy newStrat);
        void PerfomAttack(Animator animator);
    }
}
