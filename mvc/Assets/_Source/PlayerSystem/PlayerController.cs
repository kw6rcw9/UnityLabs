using UnityEngine;

namespace PlayerSystem
{
   public class PlayerController
   {
      private PlayerModel _model;
      private PlayerView _view;

      public PlayerController(PlayerModel model, PlayerView view)
      {
         _model = model;
         _view = view;

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
