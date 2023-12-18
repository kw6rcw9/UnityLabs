using UnityEngine;

namespace PlayerSystem
{
   public class PlayerController
   {
      private PlayerModel _model;
      private PlayerView _view;
      private PlayerMovement _playerMovement;
      private PlayerDamage _playerDamage;

      public PlayerController(PlayerModel model, PlayerView view, PlayerMovement playerMovement, PlayerDamage playerDamage)
      {
         _model = model;
         _view = view;
         _playerMovement = playerMovement;

      }
      public void Move(Vector3 axis)
      {
         _playerMovement.Move(axis);
      }
      public void TakeDamage(int damage)
      {
         _model.AddHp(damage);
         _view.UpdateHpText(_model.Hp);
      }

      public void Bind()
      {
         _model.OnHealthChange += _view.UpdateHpText;
         _model.OnDeath += _view.PlayerDeath;
       
         
         Debug.Log("Event binded");
      }

      public void Expose()
      {
         _model.OnHealthChange -= _view.UpdateHpText;
         _model.OnDeath -= _view.PlayerDeath;
         
         Debug.Log("Event exposed");
      }
   }
}
