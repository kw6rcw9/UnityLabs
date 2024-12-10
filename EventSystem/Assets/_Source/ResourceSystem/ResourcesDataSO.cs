using UnityEngine;

namespace ResourceSystem
{
    [CreateAssetMenu(fileName = "ResourcesDataSO", menuName = "SO/Resources Data")]
    public class ResourcesDataSo : ScriptableObject
    {
        [field: SerializeField] public string[] Resources { get; private set; }
    }
}