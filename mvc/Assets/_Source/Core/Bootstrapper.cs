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
        [SerializeField] private PlayerView playerView;
        [SerializeField] private GameObject player;
        private void Awake()
        {
            Instantiate(player);
            Debug.Log(playerView.HpText.text);
            _model = new PlayerModel();
            _playerController = new PlayerController(_model, playerView);
           _playerController.Bind();
            _model.AddHp(-1);
            _model.AddHp(4);
            Debug.Log(playerView.HpText.text);
            _playerController.Expose();
           
        }

        
    }
}
