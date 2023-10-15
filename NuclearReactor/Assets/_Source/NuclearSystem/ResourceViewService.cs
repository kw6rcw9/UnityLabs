using NuclearSystem.Data;
using UnityEngine;

namespace NuclearSystem
{
    public class ResourceViewService
    {
        private static ResourceViewService instance;
        private ResourceViewDataSO _resourceViewData = Resources.Load("NewResourceViewDataSO") 
            as ResourceViewDataSO;

        public static ResourceViewService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ResourceViewService();
                }

                return instance;
            }
        }

        public bool TryGetProcessResourceIcon(NuclearResourceType type ,out Sprite icon)
        {
            icon = null;
            if (_resourceViewData)
            {
                foreach (var viewData in _resourceViewData.ResourceViewDatas)
                {
                    if (viewData.ResourceType == type)
                    {
                        icon = viewData.ResourceProcessIcon;
                        return true;
                    }
                }
            }

            return false;
        }
        
    }
}
