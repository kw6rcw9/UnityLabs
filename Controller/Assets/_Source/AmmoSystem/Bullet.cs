using System;
using UnityEngine;

namespace AmmoSystem
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
           _rb.AddForce(transform.forward * speed * Time.deltaTime, ForceMode.Impulse);
            
        }

        private void OnCollisionEnter(Collision collision)
        {
            if(collision.gameObject.layer != 6)
                Destroy(gameObject);
        }
    }
}
