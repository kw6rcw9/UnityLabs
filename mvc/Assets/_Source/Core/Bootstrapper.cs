using System;
using InputSystem;
using PlayerSystem;
using UnityEngine;
using UnityEngine.Serialization;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        
        [SerializeField] private InputListener inputListener;
        [SerializeField] private GameObject player;
         
        private PlayerController _playerController;
        private PlayerModel _model;
        private PlayerView _playerView;
        private PlayerMovement _playerMovement;
        private void Awake()
        {
            GameObject instance = Instantiate(player);
            instance.TryGetComponent(out PlayerView playerView);
            instance.TryGetComponent(out Rigidbody2D rb);
            instance.TryGetComponent(out PlayerDamage playerDamage);
            _model = new PlayerModel();
            _playerMovement = new PlayerMovement(rb, _model.Speed);
            _playerController = new PlayerController(_model, playerView, _playerMovement, playerDamage );
            inputListener.Constructor(_playerController);
            playerDamage.Construct(_playerController, -1);
           _playerController.Bind();
            
           /*_model.AddHp(-5);
            _model.AddHp(-10);*/
           
           
        }

        private void Update()
        {
            if (_model.Hp == 0)
            {
                _playerController.Expose();
                
            }
        }
    }
}
