using System;
using Core;
using UnityEngine;

namespace InputSystem
{
    public class InputListener : MonoBehaviour
    {
        [SerializeField] private KeyCode keyCode;
        private Game _game;

        

        private void Awake()
        {
            _game = new Game();
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
