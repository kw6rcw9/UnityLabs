using UnityEngine;

namespace _Source.MonoBehaviour
{
    public class Spawner : UnityEngine.MonoBehaviour
    {
        [SerializeField] private GameObject prefab;
        [SerializeField] private int amount;

        private void Awake()
        {
            for(int i = 0; i < amount; i++)
            {
                Instantiate(prefab);
            }
        }
    }
}
