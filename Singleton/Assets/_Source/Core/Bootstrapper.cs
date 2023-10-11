using System;
using InputSystem;
using Singletons;
using UnityEngine;

namespace Core
{
   public class Bootstrapper : MonoBehaviour
   {
      [SerializeField] private InputListener inputListener;
      
      private Game _game;
      private void Awake()
      {
         _game = new Game();
         inputListener.Construct(_game);
        
      }
   }
}
