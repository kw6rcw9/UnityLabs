using System;
using EventSystem;
using MenuView;
using ResourceSystem;
using UIController;
using UnityEngine;
using UnityEngine.Serialization;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        private string ResourcesDataPath = "ResourcesDataSO";
        
       [SerializeField] private AddMenuView addMenuView;
        [SerializeField] private RemoveMenuView removeMenuView;
        [SerializeField] private MainMenuView mainMenuView;
        [SerializeField] private ResourceAddEventSo addGameEvent;
        [SerializeField] private ResourceRemoveEventSo removeGameEvent;
        [SerializeField] private ResourcesResetEventSo resetGameEvent;
        [SerializeField] private ResourceModifiedEventSo modifiedGameEvent;
        [SerializeField] private MenuSelectionBar menuMenuSelectionBar;

        private UISwitcher _uiSwitcher;
        
        private void Awake()
        {
            IUIController[] controllers =
            {
                new AddMenuController(addMenuView),
                new RemoveMenuController(removeMenuView),
                new MainMenuController(mainMenuView),
            };
            ResourcesDataSo resourcesDataSO = Resources.Load<ResourcesDataSo>(ResourcesDataPath);
            _uiSwitcher = new UISwitcher(controllers);
            menuMenuSelectionBar.Construct(_uiSwitcher);
            ResourcePool resourcePool = new ResourcePool(modifiedGameEvent,resourcesDataSO.Resources);
            removeGameEvent.RegisterObserver(resourcePool);
            resetGameEvent.RegisterObserver(resourcePool);
            addGameEvent.RegisterObserver(resourcePool);
            modifiedGameEvent.RegisterObserver(mainMenuView);
            addMenuView.Construct(addGameEvent,resourcesDataSO.Resources);
            removeMenuView.Construct(removeGameEvent,resourcesDataSO.Resources);
            mainMenuView.Construct(resetGameEvent,resourcesDataSO.Resources);
        }
    }
}
