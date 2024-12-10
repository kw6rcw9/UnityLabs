using System.Collections.Generic;
using EventSystem;
using ResourceSystem;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace MenuView
{
    public class MainMenuView : MonoBehaviour, IResourcesModifiedEventListener
    {
        [SerializeField] private GameObject menuPanel;
        [SerializeField] private Button resetButton;
        [SerializeField] private RectTransform resourcesLayout;
        [SerializeField] private GameObject resourceViewPrefab;

        private ResourcesResetEventSo _resetEventSo;
        private Dictionary<string, ResourceView> _resourceViews;
        
        public void Construct(ResourcesResetEventSo resetEventSo, string[] resources)
        {
            _resetEventSo = resetEventSo;
            _resourceViews = new Dictionary<string, ResourceView>();
            foreach (var resource in resources)
            {
                ResourceView resourceView = Instantiate(resourceViewPrefab, resourcesLayout).GetComponent<ResourceView>();
                resourceView.ResourceName = resource;
                _resourceViews.Add(resource, resourceView);
            }
        }
        
        private void Awake()
        {
            resetButton.onClick.AddListener(ResetResources);
        }

        private void ResetResources()
        {
            _resetEventSo.Notify();
        }

        public void OpenMenu()
        {
            menuPanel.SetActive(true);
        }
        
        public void CloseMenu()
        {
            menuPanel.SetActive(false);
        }

        void IResourcesModifiedEventListener.OnGameEvent(string resourceName, int count)
        {
            _resourceViews[resourceName].Count = count;
        }
    }
}
