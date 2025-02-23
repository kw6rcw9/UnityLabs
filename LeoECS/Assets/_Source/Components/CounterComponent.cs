using System;
using UnityEngine;

namespace _Source.Components
{
    [Serializable]
    public struct CounterComponent 
    {
        [field: SerializeField] public float Count { get; set; }
    }
}
