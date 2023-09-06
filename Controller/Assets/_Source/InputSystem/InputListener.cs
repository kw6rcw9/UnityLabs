using System;
using PlayerSystem;
using UnityEditor;
using UnityEngine;

namespace InputSystem
{
    public class InputListener : MonoBehaviour
    {
        [SerializeField] private KeyCode jumpKey;
        [SerializeField] private Player player;
        private PlayerInvoker _playerInvoker;

        public bool InputEnabled { get; private set; }


        private void Awake()
        {
            _playerInvoker = new PlayerInvoker(player);
            InputEnabled = true;
        }

        void Update()
        {
            OffInput();
            OnInput();
            ReadJump();
            ReadMove();
            ReadRotate();
            ReadShoot();
        
        }

       

        private void ReadJump()
        {
            if (Input.GetKeyDown(jumpKey) && InputEnabled && player.IsOnGround)
            {
                _playerInvoker.Jump();
                
            }
        }

        private void ReadRotate()
        {
            if (InputEnabled)
            { 
                float x = Input.GetAxis("Horizontal");
                float z = Input.GetAxis("Vertical");
                _playerInvoker.Rotate(x, z);
            }
                
            
            
        }

        private void OffInput()
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                InputEnabled = false;
                Debug.Log("Input is disabled");

            }
            
        }

        private void OnInput()
        {
            
            if (Input.GetMouseButtonDown(0) && !InputEnabled)
            {
                InputEnabled = true;
                Debug.Log("Input is enabled");

            }
            
        }

        private void ReadMove()
        {
            if (InputEnabled)
            {
                float x = Input.GetAxis("Horizontal");
                float z = Input.GetAxis("Vertical");
                _playerInvoker.Move(x,z);
                
            }
            
            

        }

        private void ReadShoot()
        {
            if (Input.GetKeyDown(KeyCode.Q) && InputEnabled)
            {
                _playerInvoker.Shoot();
            }
        }
    }
}
