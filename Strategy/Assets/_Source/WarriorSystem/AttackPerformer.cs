using System;
using System.Collections;
using EnemySystem;
using UnityEngine;

namespace WarriorSystem
{
   public class AttackPerformer: MonoBehaviour
   {
      [SerializeField] private Animator animator;
      private IContext _context;
      public static Action OnAttack;


      public void Construct(IContext context)
      {
         _context = context;
      }
      public void PerfomAttack()
      {
         _context.PerfomAttack(animator);
         OnAttack?.Invoke();
      }

      
   }
}
