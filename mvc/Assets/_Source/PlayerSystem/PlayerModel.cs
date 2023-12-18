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

        private const int _speed = 5;

        public int Speed => _speed;
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
                Debug.Log("Dead");
                OnDeath?.Invoke();
            }
            OnHealthChange?.Invoke(Hp);
            
        }
        
        
    }
}
