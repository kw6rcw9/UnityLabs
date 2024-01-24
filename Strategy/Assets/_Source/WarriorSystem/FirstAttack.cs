using UnityEngine;

namespace WarriorSystem
{
    public class FirstAttack : IAttackStrategy
    {
  
        public void Attack(Animator animator)
        {
            animator.SetTrigger("FirstAttack");
        }
    }
}
