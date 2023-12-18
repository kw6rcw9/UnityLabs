using PlayerSystem;
using UnityEngine;

namespace InputSystem
{
    public class InputListener : MonoBehaviour
    {
        private PlayerController _player;
        
        public void Constructor(PlayerController player)
        {
            _player = player;
        }

        private void Update()
        {
            ReadPlayerMove();
        }

        private void ReadPlayerMove()
        {
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");
            
            _player.Move(new Vector3(x,y));
        }
    }
}
