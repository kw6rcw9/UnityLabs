using UnityEngine;

namespace EnemySystem
{
    public class Shooting
    {
        private Transform _firePoint;
        private GameObject _bulletPrefab;
        public Shooting(Transform firePoint, GameObject bulletPrefab)
        {
            _firePoint = firePoint;
            _bulletPrefab = bulletPrefab;
        }
        public void Shoot()
        {
           
            GameObject bullet = GameObject.Instantiate(_bulletPrefab);



        }
    }
}
