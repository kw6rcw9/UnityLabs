using UnityEngine;
using WarriorSystem;

namespace Core
{
   public class Bootstrapper : MonoBehaviour
   {
      [SerializeField] private InputListener inputListener;
      [SerializeField] private SetButtons setButtons;
      [SerializeField] private AttackPerformer attackPerformer;
  
      private IContext _context;
  
   
      private void Awake()
      {
         _context = new Context(null);
         attackPerformer.Construct(_context);
         setButtons.Construct(_context);
         inputListener.Construct(attackPerformer);
      }
   }
}
