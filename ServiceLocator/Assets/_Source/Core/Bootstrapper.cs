using Audio;
using SaveSystem;
using ScoreSystem;
using UISystem;
using UISystem.ExtraPanel;
using UISystem.Menu;
using UnityEngine;
using UnityEngine.Serialization;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        private const string SCORE_PATH = "ScoreData.json";
        [SerializeField] private float fadeInDur;
        [SerializeField] private float fadeOutDur;
        [SerializeField] private ExtraPanelView extraPanelView;
        [SerializeField] private MenuView menuView;
        [SerializeField] private AudioSource openUISoundSource;
        [SerializeField] private AudioSource closeUISoundSource;
        private IUIState[] _uiStates;
        private UISwitcher _uiSwitcher;
        private IServiceLocator _serviceLocator;
        private Score _score;
        private SoundPlayer _soundPlayer;
        private FadeService _fadeService;
        private JsonSaver _jsonSaver;
        private PlayerPrefsSaver _playerPrefsSaver;
        
        private void Awake()
        {
            
            _score = new Score(extraPanelView);
            _soundPlayer = new SoundPlayer(openUISoundSource, closeUISoundSource);
            _fadeService = new FadeService();
            _jsonSaver = new JsonSaver(_score);
            _playerPrefsSaver = new PlayerPrefsSaver(_score);
            
            _score.SetScore(_jsonSaver.LoadScore(SCORE_PATH));
            
            IService[] services =
            {
                _soundPlayer,
                _fadeService,
                _jsonSaver,
                _playerPrefsSaver,
                _score
            };
            
            _serviceLocator = new ServiceLocator(services);
            
            _uiStates = new IUIState[]
            {
                new ExtraPanelUIState(_serviceLocator, extraPanelView, fadeInDur),
                new MenuUIState(_serviceLocator, extraPanelView, menuView, fadeOutDur)
            };

            _uiSwitcher = new UISwitcher(_uiStates);
            _uiSwitcher.SwitchState<MenuUIState>();
        }
    }
}