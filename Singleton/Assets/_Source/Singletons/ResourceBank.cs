using System.Collections.Generic;
using ResourceSystem;
using UnityEngine;
using UnityEngine.UI;

namespace Singletons
{
    public class ResourceBank : MonoBehaviour
    {
        
        private Resource _resource;
        private Dictionary<ResourceType, Resource> _dict;
        public static ResourceBank Instance
        {
            get;
            private set;
        }

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                _dict = new Dictionary<ResourceType, Resource>();
                DontDestroyOnLoad(gameObject);
                return;
            }
            Destroy(gameObject);
        }

        public int GetResource( ResourceType resourceType)
        {
            return _dict.ContainsKey(resourceType) ? _dict[resourceType].ResourceAmount : 0;
        }

        public void AddResource(ResourceType resourceType, int newNum)
        {
           
            
            if(!_dict.ContainsKey(resourceType))
                _dict.Add(resourceType, new Resource(resourceType, newNum));
            else
            {
                _dict[resourceType].ResourceAmount += newNum;
            }
            
            Debug.Log(_dict[resourceType].Type + " - " + GetResource(resourceType));
            
        }
    }
}
