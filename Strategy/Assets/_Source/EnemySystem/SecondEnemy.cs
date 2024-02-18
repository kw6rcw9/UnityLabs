using System;
using System.Collections;
using System.Threading;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

namespace EnemySystem
{
    public class SecondEnemy : ABaseClass
    {
       
        [field: SerializeField] public override Animator Animator { get; set; }
        private Shooting _shooting;
        [SerializeField]private Transform _firePoing;
        [SerializeField] private GameObject _bullet;
        private bool _isReady = false;

      

        private void OnEnable()
        {
            if (_isReady)
            {
                _shooting = new Shooting(_firePoing, _bullet);
                TemplateAttack();
                
            }
        }

        private void OnDisable()
        {
            _isReady = true;
        }


        protected override void Attack()
        {
            StartCoroutine(AwaitTime());
                _shooting.Shoot();
                
                
            
            
        }

        IEnumerator AwaitTime()
        {
            
            yield return new WaitForSeconds(1);
            Attack();
            StartCoroutine(AwaitTime());
        }

       

        
    }

   
}
