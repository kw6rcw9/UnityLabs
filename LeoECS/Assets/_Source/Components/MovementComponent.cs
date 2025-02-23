using System;
using UnityEngine;

namespace _Source.Components
{
    [Serializable]
    public struct MovementComponent
    {
        [field: SerializeField]public Transform Ball { get; set; }
        [field: SerializeField]public float Speed { get; set; }
        [field: SerializeField]public float Magnitude { get; set; }
        [field: SerializeField]public float Frequency { get; set; }
    }
}
