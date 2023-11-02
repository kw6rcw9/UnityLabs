using System;
using Unity.VisualScripting;
using UnityEngine;

namespace PlayerSystem
{
    public class PlayerModel 
    {
        public event Action<int> OnHealthChange;
        public event Action OnDeath;
        private const  int _maxHp = 10;
        public int Hp { get; private set; }

        public PlayerModel()
        {
            Hp = _maxHp;
            
        }
        public void AddHp(int value)
        {
            Hp += value;
            if (Hp <= 0)
            {
                Hp = 0;
                OnDeath?.Invoke();
            }
            OnHealthChange?.Invoke(Hp);
            
        }
        
        
    }
}
