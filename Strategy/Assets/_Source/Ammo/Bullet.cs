using System.Collections;
using UnityEngine;

namespace Ammo
{ 
    [RequireComponent(typeof(Rigidbody))]
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private float speed;
        private Rigidbody _rb;

        private void Awake()
        {
            _rb = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            MoveForward();
        }

        private void MoveForward()
        {
            _rb.AddForce(-transform.right * speed * Time.deltaTime, ForceMode.Impulse);
            StartCoroutine(DestroyTime());

        }
        private IEnumerator DestroyTime()
        {
            yield return new WaitForSeconds(2);
            Destroy(gameObject);
        }
    }
}
