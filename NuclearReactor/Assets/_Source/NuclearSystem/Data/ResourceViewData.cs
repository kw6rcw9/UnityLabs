using System;
using UnityEngine;

namespace NuclearSystem.Data
{
    [Serializable]
    public class ResourceViewData
    {
        [field: SerializeField] public NuclearResourceType ResourceType { get; private set; }
        [field: SerializeField] public Sprite ResourceProcessIcon { get; private set; }
        [field: SerializeField] public Sprite ResourceDecayIcon { get; private set; }
    }
}