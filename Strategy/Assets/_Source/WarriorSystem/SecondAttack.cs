using UnityEngine;

namespace WarriorSystem
{
    public class SecondAttack : IAttackStrategy
    {
    

        public void Attack(Animator animator)
        {
            animator.SetTrigger("SecondAttack"); 
        }
    }
}
