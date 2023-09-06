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
        private bool _isOnGround = true;
        public bool IsOnGround { get => _isOnGround;}

        private void Awake()
        {
            Rb = GetComponent<Rigidbody>();
           

        }
        private void OnCollisionEnter(Collision other)
        {
            _isOnGround = true;
        }

        private void OnCollisionExit(Collision other)
        {
            _isOnGround = false;
        }
    }
}
