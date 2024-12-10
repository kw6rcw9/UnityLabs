using EventSystem;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace MenuView
{
    public class AddMenuView : MonoBehaviour
    {
        [SerializeField] private GameObject menuPanel;
        [SerializeField] private Button addButton;
        [SerializeField] private TMP_Dropdown resourcesDropdown; 
        [SerializeField] private TMP_InputField countInputField;

        private ResourceAddEventSo _addEventSo;
        
        public void Construct(ResourceAddEventSo addEventSo, string[] resources)
        {
            _addEventSo = addEventSo;
            resourcesDropdown.ClearOptions();
            foreach (var name in resources)
            {
                resourcesDropdown.options.Add(new TMP_Dropdown.OptionData(name));
            }
        }
        
        private void Awake()
        {
            addButton.onClick.AddListener(AddResource);
        }

        private void AddResource()
        {
            if(!int.TryParse(countInputField.text,out var count))
                return;
            _addEventSo.Notify(resourcesDropdown.options[resourcesDropdown.value].text,count);
        }
        
        public void OpenMenu()
        {
            menuPanel.SetActive(true);
        }
        
        public void CloseMenu()
        {
            menuPanel.SetActive(false);
        }

        public void OnGameEvent(string resourceName, int count)
        {
            
        }
    }
}
