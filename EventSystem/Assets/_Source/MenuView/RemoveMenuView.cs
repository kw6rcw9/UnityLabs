using EventSystem;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace MenuView
{
    public class RemoveMenuView : MonoBehaviour
    {
        [SerializeField] private GameObject menuPanel;
        [SerializeField] private Button removeButton;
        [SerializeField] private TMP_Dropdown resourcesDropdown;
        [SerializeField] private TMP_InputField countInputField;
        
        private ResourceRemoveEventSo _removeEventSo;
        
        public void Construct(ResourceRemoveEventSo removeEventSo, string[] resources)
        {
            
            _removeEventSo = removeEventSo;
            resourcesDropdown.ClearOptions();
            foreach (var name in resources)
            {
                resourcesDropdown.options.Add(new TMP_Dropdown.OptionData(name));
            }
            
        }
        
        private void Awake()
        {
            
            removeButton.onClick.AddListener(RemoveResource);
        }
        
        private void RemoveResource()
        {
            
            if(!int.TryParse(countInputField.text,out var count))
                return;
            _removeEventSo.Notify(resourcesDropdown.options[resourcesDropdown.value].text,count);
        }
        
        public void OpenMenu()
        {
            
            menuPanel.SetActive(true);
        }
        
        public void CloseMenu()
        {
            
            menuPanel.SetActive(false);
        }
    }
}
