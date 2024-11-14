using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace UISystem.Menu
{
    public class MenuView : MonoBehaviour
    {
        [SerializeField] private Button openButton;

        public void OpenButtonSubscribe(UnityAction action)
        {
            openButton.onClick.AddListener(action);
        }
    
        public void OpenButtonUnsubscribe(UnityAction action)
        {
            openButton.onClick.RemoveListener(action);
        }
    }
}
