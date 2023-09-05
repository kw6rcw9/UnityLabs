using System;
using PlayerSystem;
using UnityEngine;

namespace InputSystem
{
    public class InputListener : MonoBehaviour
    {
        [SerializeField] private KeyCode jumpKey;
        [SerializeField] private Player player;
        private PlayerInvoker _playerInvoker;
        private bool _inputEnabled = true;
        private bool _isOnGround = true;

        private void Awake()
        {
            _playerInvoker = new PlayerInvoker(player);
        }

        void Update()
        {
            OffInput();
            OnInput();
            ReadJump();
            ReadMove();
            ReadRotate();
        
        }

        private void OnTriggerEnter(Collider other)
        {
            _isOnGround = true;
        }

        private void OnTriggerExit(Collider other)
        {
            _isOnGround = false;
        }

        private void ReadJump()
        {
            if (Input.GetKeyDown(jumpKey) && _inputEnabled && _isOnGround)
            {
                _playerInvoker.Jump();
                
            }
        }

        private void ReadRotate()
        {
            if(_inputEnabled)
                _playerInvoker.Rotate();
            
            
        }

        private void OffInput()
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                _inputEnabled = false;
                Debug.Log("Input is disabled");

            }
            
        }

        private void OnInput()
        {
            
            if (Input.GetMouseButtonDown(0) && !_inputEnabled)
            {
                _inputEnabled = true;
                Debug.Log("Input is enabled");

            }
            
        }

        private void ReadMove()
        {
            if(_inputEnabled)
                _playerInvoker.Move();
            
            

        }
    }
}
