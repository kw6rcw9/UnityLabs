using Audio;
using Core;
using SaveSystem;
using ScoreSystem;
using UISystem.Menu;

namespace UISystem.ExtraPanel
{
    public class ExtraPanelUIState : IUIState
    {
        private const string SCORE_SAVE_PATH = "ScoreData.json";
        
        private readonly ExtraPanelView _extraPanelView;
        private readonly SoundPlayer _soundPlayer;
        private readonly FadeService _fadeService;
        private readonly Score _score;
        private readonly JsonSaver _jsonSaver;
        private readonly float _fadeDuration;
        private IUIStateMachine _owner;
        
        public ExtraPanelUIState(IServiceLocator serviceLocator, 
            ExtraPanelView extraPanelView, float fadeDuration)
        {
            serviceLocator.TryGetService(out _soundPlayer);
            serviceLocator.TryGetService(out _fadeService);
            serviceLocator.TryGetService(out _score);
            serviceLocator.TryGetService(out _jsonSaver);
            _extraPanelView = extraPanelView;
            _extraPanelView.SetScore(_score.CurrentScore);
            _fadeDuration = fadeDuration;
        }

        public void SetOwner(IUIStateMachine owner)
        {
            _owner = owner;
        }

        public void Enter()
        {
            _extraPanelView.CloseButtonSubscribe(FadeInPanel);
            _extraPanelView.CollectButtonSubscribe(AddScore);
        }

        public void Exit()
        {
            _extraPanelView.CloseButtonUnsubscribe(FadeInPanel);
            _extraPanelView.CollectButtonUnsubscribe(AddScore);
        }

        private void FadeInPanel()
        {
            _soundPlayer?.PlayCloseSound();
            _fadeService?.FadeIn(_extraPanelView.CanvasGroup,_fadeDuration,CloseAdditionalPanel);
        }

        private void CloseAdditionalPanel()
        {
            _jsonSaver.SaveScore(SCORE_SAVE_PATH);
            _extraPanelView.ClosePanel();
            _owner.SwitchState<MenuUIState>();
        }

        private void AddScore()
        {
            _score.AddScore();
        }
    }
}