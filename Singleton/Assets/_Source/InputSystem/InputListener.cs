using System;
using Core;
using UnityEngine;

namespace InputSystem
{
    public class InputListener : MonoBehaviour
    {
        [SerializeField] private KeyCode keyCode;
        private Game _game;



        public void Construct(Game game)
        {
            _game = game;
        }

        void Update()
        {
            ReloadScene();
        
        }

        private void ReloadScene()
        {
            if(Input.GetKeyDown(keyCode))
                _game.ReloadScene();
                
        }
    }
}
