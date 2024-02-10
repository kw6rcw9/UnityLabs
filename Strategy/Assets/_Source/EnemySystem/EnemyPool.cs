using System.Collections.Generic;
using UnityEngine;

namespace EnemySystem
{
    public class EnemyPool : MonoBehaviour
    {
        [SerializeField] private GameObject enemyPrefab;
        [SerializeField] private int poolSize;
        private List<GameObject> _enemies;
        public void Construct()
        {
            InitPool();
        }

        private void InitPool()
        {
            _enemies = new List<GameObject>();
            for (int i = 0; i < poolSize; i++)
            {
                GameObject enemyInstance = Instantiate(enemyPrefab, transform);
                ReturnToPool(enemyInstance);
            }
        }

        public bool TryGetFromPool(out GameObject enemyInstance)
        {
            enemyInstance = null;
            if (_enemies.Count > 0)
            {
                enemyInstance = _enemies[0];
                enemyInstance.SetActive(true);
                _enemies.RemoveAt(0);
                return true;
            }

            return false;
        }

        public void ReturnToPool(GameObject enemyInstance)
        {
            enemyInstance.SetActive(false);
            _enemies.Add(enemyInstance);
        }
    }
}
