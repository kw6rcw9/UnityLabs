using Core;
using Unity.VisualScripting;
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
            ApplicationExit();
            
            
        }

        private void ApplicationExit()
        {
            if (Input.GetKeyDown(keyCode))
                _game.OnApplicationExit();
            
        }
    }
}
