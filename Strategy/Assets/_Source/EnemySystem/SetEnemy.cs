using System;
using UnityEngine;

namespace EnemySystem
{
    public class SetEnemy
    {
        private ABaseClass _currentEnemy;
        private EnemyPool _enemyPool;
        private GameObject _activeEnemy;

        public SetEnemy(EnemyPool enemyPool)
        {
            _enemyPool = enemyPool;
            _activeEnemy = null;
        }
        public void ChangeActiveEnemy(Type newAnemy, GameObject spawnPoint)
        {
            
            if (_activeEnemy != null)
            {
                _enemyPool.ReturnToPool(_activeEnemy);
            }
            if(_enemyPool.TryGetFromPool(out GameObject enemyInstance, newAnemy))
            {
                enemyInstance.transform.position = spawnPoint.transform.position;
                _activeEnemy = enemyInstance;
               
               
                
                
                //Attack();
            }

            

        }

        


    }
}
