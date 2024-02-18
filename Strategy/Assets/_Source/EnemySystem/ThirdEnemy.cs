using System;
using UnityEngine;
using WarriorSystem;

namespace EnemySystem
{
    public class ThirdEnemy : ABaseClass
    {
       
        [field: SerializeField] public override Animator Animator { get; set; }

        private void OnEnable()
        {
            TemplateAttack();
        }

        protected override void Attack()
        {
            AttackPerformer.OnAttack += AttackAnim;
        }

        void AttackAnim()
        {
            Animator.SetTrigger("ThirdAttack");
        }

        
    }
}
