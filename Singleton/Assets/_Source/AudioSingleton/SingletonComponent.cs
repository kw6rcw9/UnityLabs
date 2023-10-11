using System;
using UnityEngine;

namespace AudioSingleton
{
    public class SingletonComponent : MonoBehaviour
    {
        public static SingletonComponent Instance
        {
            get;
            private set;
        }

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
                return;
            }
            Destroy(gameObject);
        }
    }
}
