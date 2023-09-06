using UnityEngine;

namespace PlayerSystem
{
    public class PlayerInvoker
    {
        private PlayerMovement _playerMovement;
        private PlayerCombat _playerCombat;
        private Player _player;
        public PlayerInvoker (Player player)
        {
            _playerMovement = new PlayerMovement();
            _player = player;
            _playerCombat = new PlayerCombat();
        }

        public void Move(float x, float z)
        {
            _playerMovement.Move(x, z, _player.Rb, _player.MovementSpeed);
        }

        public void Jump()
        {
            _playerMovement.Jump(_player.Rb, _player.JumpForce);
        }

        public void Rotate(float x, float z)
        {
            _playerMovement.Rotate(x,z, _player.Rb, _player.RotationSpeed,_player.transform);
        }

        public void Shoot()
        {
            _playerCombat.Shoot( _player.FirePoint, _player.BulletPrefab);
            
        }
    }
}
