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
        public void ChangeActiveEnemy(ABaseClass newAnemy, GameObject spawnPoint)
        {
            _currentEnemy = newAnemy;
            if (_activeEnemy != null)
            {
                _enemyPool.ReturnToPool(_activeEnemy);
            }
            if(_enemyPool.TryGetFromPool(out GameObject enemyInstance))
            {
                enemyInstance.transform.position = spawnPoint.transform.position;
                _activeEnemy = enemyInstance;
                if (enemyInstance.TryGetComponent(out Enemy enemy))
                {
                    enemy.Init(_currentEnemy);
                }
            }

            

        }

        public void Attack()
        {
            _currentEnemy.TemplateAttack();
        }


    }
}
