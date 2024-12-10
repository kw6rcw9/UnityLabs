using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

namespace ResourceSystem
{
    public class ResourceView : MonoBehaviour
    {
        [SerializeField] private TMP_Text countText;
        [SerializeField] private TMP_Text resourceNameText;
        private int _count;
        private string _resourceName;
        
        public int Count
        {
            get => _count;
            set
            {
                _count = value;
                countText.text = _count.ToString();
            }
        }
        
        public string ResourceName
        {
            get => _resourceName;
            set
            {
                _resourceName = value;
                resourceNameText.text = _resourceName;
            }
        }
    }
}