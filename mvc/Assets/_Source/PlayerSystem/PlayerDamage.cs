using UnityEngine;

namespace PlayerSystem
{
    public class PlayerDamage : MonoBehaviour
    {
        [SerializeField] private LayerMask enemyMask;
        private PlayerController _player;
        private int _damage;
        
        public void Construct(PlayerController player, int damage)
        {
            _player = player;
            _damage = damage;
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            if(enemyMask == (enemyMask  | (1<<other.gameObject.layer)))
            {
                _player.TakeDamage(_damage);
            }
        }
    }
}
