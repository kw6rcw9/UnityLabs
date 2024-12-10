using Core;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace UIController
{
    public class MenuSelectionBar: MonoBehaviour
    {
        [SerializeField] private Button mainMenuButton;
        [SerializeField] private Button addMenuButton;
        [SerializeField] private Button removeMenuButton;

        private UISwitcher _uiSwitcher;
        
        public void Construct(UISwitcher uiSwitcher)
        {
            _uiSwitcher = uiSwitcher;
        }
        
        private void Start()
        {
            mainMenuButton.onClick.AddListener(OpenMainMenu);
            addMenuButton.onClick.AddListener(OpenAddMenu);
            removeMenuButton.onClick.AddListener(OpenRemoveMenu);
        }

        private void OpenMainMenu()
        {
            _uiSwitcher.ChangeState<MainMenuController>();
        }
        private void OpenAddMenu()
        {
            _uiSwitcher.ChangeState<AddMenuController>();
        }
        private void OpenRemoveMenu()
        {
            _uiSwitcher.ChangeState<RemoveMenuController>();
        }
    }
}