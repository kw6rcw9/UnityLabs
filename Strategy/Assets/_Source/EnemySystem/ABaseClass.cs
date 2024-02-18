using UnityEngine;

namespace EnemySystem
{
    public abstract class ABaseClass: MonoBehaviour
    {
        
        public abstract Animator Animator { get; set; }
       
         protected abstract  void Attack();

         public void TemplateAttack()
         {
             Attack();
         }
    }
}
