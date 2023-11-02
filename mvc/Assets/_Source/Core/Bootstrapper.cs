using System;
using PlayerSystem;
using UnityEngine;
using UnityEngine.Serialization;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        private PlayerController _playerController;
        private PlayerModel _model;
        private PlayerView _playerView;
        [SerializeField] private GameObject player;
        private void Awake()
        {
            _model = new PlayerModel();
            GameObject instance = Instantiate(player);
            instance.TryGetComponent(out PlayerView playerView);
            _playerController = new PlayerController(_model, playerView);
           _playerController.Bind();
           _model.AddHp(-5);
            _model.AddHp(-10);
            _playerController.Expose();
           
        }

        
    }
}
