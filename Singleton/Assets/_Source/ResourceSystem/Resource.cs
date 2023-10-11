using UnityEngine;

namespace ResourceSystem
{
    public class Resource 
    {
        public ResourceType Type { get; set; }
        public int ResourceAmount { get; set; }

        public Resource(ResourceType resourceType, int resourceAmount)
        {
            Type = resourceType;
            ResourceAmount = resourceAmount;
        }
    }
}