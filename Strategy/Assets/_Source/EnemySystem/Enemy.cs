using UnityEngine;

namespace EnemySystem
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private Animator animator;
        private ABaseClass _enemy;


       
        public void Init(ABaseClass enemy)
        {
            _enemy = enemy;
            
        }

        public void Attack()
        {
            _enemy.TemplateAttack();   
        }

    }
}
