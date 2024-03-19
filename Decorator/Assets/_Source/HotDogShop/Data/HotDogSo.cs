using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "HotDogSO", menuName = "SO/HotdogData")]
public class HotDogSo : ScriptableObject
{
    [field: SerializeField] public int Weight { get; private set; }
}
