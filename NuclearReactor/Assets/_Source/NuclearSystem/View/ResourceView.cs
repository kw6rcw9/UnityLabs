using NuclearSystem.Data;
using UnityEngine;
using UnityEngine.UI;

namespace NuclearSystem.View
{
    [RequireComponent(typeof(Image))]
    public class ResourceView : MonoBehaviour
    {
        [SerializeField] private NuclearResourceType resourceType;
        private Image _icon;
      
        void Start()
        {
            _icon = GetComponent<Image>();
            if (ResourceViewService.Instance.TryGetProcessResourceIcon(resourceType, out Sprite processIcon))
            {
                _icon.sprite = processIcon;
            } 
        }

       
    }
}
