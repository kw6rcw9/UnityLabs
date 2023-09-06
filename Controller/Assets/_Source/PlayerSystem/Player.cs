using System;
using UnityEngine;

namespace PlayerSystem
{
    [RequireComponent(typeof(Rigidbody))]
   
    public class Player : MonoBehaviour
    {
        [field: SerializeField] public float MovementSpeed { get; private set; }
        [field: SerializeField] public float RotationSpeed { get; private set; }
        [field: SerializeField] public float JumpForce { get; private set; }
        [field: SerializeField] public Rigidbody Rb { get; private set; }
        [field: SerializeField] public Transform FirePoint { get; private set; }
        [field: SerializeField] public GameObject BulletPrefab { get; private set; }

        public bool IsOnGround { get; private set; }
   

        private void Awake()
        {
            Rb = GetComponent<Rigidbody>();
           

        }
        private void OnCollisionEnter(Collision other)
        {
            IsOnGround = true;
        }

        private void OnCollisionExit(Collision other)
        {
            IsOnGround = false;
        }
    }
}
