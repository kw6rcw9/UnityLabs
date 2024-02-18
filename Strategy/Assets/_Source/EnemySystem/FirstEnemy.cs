using System;
using UnityEngine;

namespace EnemySystem
{
    public class FirstEnemy : ABaseClass
    {
      
        [field: SerializeField] public override Animator Animator { get; set; }


        private void OnEnable()
        {
            TemplateAttack();
           
        }

        protected override void Attack()
        {
            Animator.SetTrigger("FirstAttack");
        }

    }
}
