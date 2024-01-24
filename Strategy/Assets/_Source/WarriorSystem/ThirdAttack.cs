using UnityEngine;

namespace WarriorSystem
{
    public class ThirdAttack : IAttackStrategy
    {
    

        public void Attack(Animator animator)
        {
            animator.SetTrigger("ThirdAttack"); 
        }
    }
}
