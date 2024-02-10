using EnemySystem;
using UnityEngine;
using WarriorSystem;

namespace Core
{
   public class Bootstrapper : MonoBehaviour
   {
      [SerializeField] private InputListener inputListener;
      [SerializeField] private SetButtons setButtons;
      [SerializeField] private AttackPerformer attackPerformer;
      [SerializeField] private EnemyPool enemyPool;
      private SetEnemy _setEnemy;
  
      private IContext _context;
  
   
      private void Awake()
      {
         enemyPool.Construct();
         _setEnemy = new SetEnemy(enemyPool);
         _context = new Context(null);
         attackPerformer.Construct(_context);
         setButtons.Construct(_context, _setEnemy);
         inputListener.Construct(attackPerformer);
      }
   }
}
