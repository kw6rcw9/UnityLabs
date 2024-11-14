using ScoreSystem;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace UISystem.ExtraPanel
{
    public class ExtraPanelView : MonoBehaviour,IScoreView
    {
        [SerializeField] private Button closeButton;
        [SerializeField] private Button collectButton;
        [SerializeField] private TMP_Text scoreText;
        [SerializeField] private RectTransform panel;
        
        [field: SerializeField] public CanvasGroup CanvasGroup { get; private set; }
        
        public void CloseButtonSubscribe(UnityAction action)
        {
            closeButton.onClick.AddListener(action);
        }
    
        public void CloseButtonUnsubscribe(UnityAction action)
        {
            closeButton.onClick.RemoveListener(action);
        }
        
        public void CollectButtonSubscribe(UnityAction action)
        {
            collectButton.onClick.AddListener(action);
        }
        
        public void CollectButtonUnsubscribe(UnityAction action)
        {
            collectButton.onClick.RemoveListener(action);
        }
        
        public void ClosePanel()
        {
            panel.gameObject.SetActive(false);
        }
        
        public void OpenPanel()
        {
            panel.gameObject.SetActive(true);
        }

        public void SetScore(int score)
        {
            scoreText.text = score.ToString();
        }
    }
}
