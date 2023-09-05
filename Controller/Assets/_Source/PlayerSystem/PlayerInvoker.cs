using UnityEngine;

namespace PlayerSystem
{
    public class PlayerInvoker
    {
        private PlayerMovement _playerMovement;
        private Player _player;
        public PlayerInvoker (Player player)
        {
            _playerMovement = new PlayerMovement();
            _player = player;

        }

        public void Move()
        {
            _playerMovement.Move(_player.Rb, _player.MovementSpeed);
        }

        public void Jump()
        {
            _playerMovement.Jump(_player.Rb, _player.JumpForce);
            
        }

        public void Rotate()
        {
            _playerMovement.Rotate(_player.Rb, _player.RotationSpeed,_player.transform);
        }
    }
}
