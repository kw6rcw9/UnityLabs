using System.Collections.Generic;
using ResourceSystem;
using UnityEngine;
using UnityEngine.UI;

namespace Singletons
{
    public class AudioComponent : MonoBehaviour
    {
        public static AudioComponent Instance
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
