using System;
using TMPro;
using UnityEngine;

namespace PlayerSystem
{
    public class PlayerView : MonoBehaviour
    {
        [field: SerializeField] public TextMeshProUGUI HpText { get; private set; }
        [SerializeField] private Color deathColor;

        

        public void UpdateHpText(int hp)
        {
            HpText.text = $"Current hp: {hp}";
            
            TryGetComponent(out SpriteRenderer sprite);
           
        }

        public void PlayerDeath()
        {
            TryGetComponent(out SpriteRenderer sprite);
            sprite.color = deathColor;
        }
    }
}
