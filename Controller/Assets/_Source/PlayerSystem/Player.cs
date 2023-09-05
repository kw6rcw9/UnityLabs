using System;
using UnityEngine;

namespace PlayerSystem
{
    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(Transform))]
    public class Player : MonoBehaviour
    {
        [field: SerializeField] public float MovementSpeed { get; private set; }
        [field: SerializeField] public float RotationSpeed { get; private set; }
        [field: SerializeField] public float JumpForce { get; private set; }
        [field: SerializeField] public Rigidbody Rb { get; private set; }
       

        private void Awake()
        {
            Rb = GetComponent<Rigidbody>();
           

        }
    }
}
