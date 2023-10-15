using System.Collections.Generic;
using NuclearSystem;
using NuclearSystem.View;
using UnityEngine;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private List<ResourceView> resourceButtons;
        private ResourceViewService _resourceViewService;

        private void Awake()
        {
            _resourceViewService = new ResourceViewService();
            foreach (var resourceButton in resourceButtons)
            {
            
            }
        }
    }
}
