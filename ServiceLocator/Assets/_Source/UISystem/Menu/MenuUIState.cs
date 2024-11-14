using Audio;
using Core;
using UISystem.ExtraPanel;

namespace UISystem.Menu
{
    public class MenuUIState : IUIState
    {
        private readonly ExtraPanelView _extraPanelView;
        private readonly MenuView _menuView;
        private readonly SoundPlayer _soundPlayer;
        private readonly FadeService _fadeService;
        private readonly float _fadeDuration;
        private IUIStateMachine _owner;

        public MenuUIState(IServiceLocator serviceLocator,ExtraPanelView extraPanelView, 
            MenuView menuView, float fadeDuration)
        {
            serviceLocator.TryGetService(out _soundPlayer);
            serviceLocator.TryGetService(out _fadeService);
            _extraPanelView = extraPanelView;
            _menuView = menuView;
            _fadeDuration = fadeDuration;
        }
        
        public void SetOwner(IUIStateMachine owner)
        {
            _owner = owner;
        }
        
        public void Enter()
        {
            _menuView.OpenButtonSubscribe(OpenAdditionalPanel);
        }
        
        public void Exit()
        {
            _menuView.OpenButtonUnsubscribe(OpenAdditionalPanel);
        }
        
        private void OpenAdditionalPanel()
        {
            _extraPanelView.OpenPanel();
            _owner.SwitchState<ExtraPanelUIState>();
            _soundPlayer?.PlayOpenSound();
            _fadeService?.FadeOut(_extraPanelView.CanvasGroup,_fadeDuration);
        }
    }
}