using Core;
using ScoreSystem;
using UnityEngine;

namespace SaveSystem
{
    public class PlayerPrefsSaver : ISaver, IService
    {
        private const string SCORE_SAVE_KEY = "Score";
        
        private readonly Score _score;
        
        public PlayerPrefsSaver(Score score)
        {
            _score = score;
        }
        
        public void SaveScore(string path = null)
        {
            PlayerPrefs.SetInt(SCORE_SAVE_KEY,_score.CurrentScore);
            PlayerPrefs.Save();
        }

        public int LoadScore(string path = null)
        {
            return PlayerPrefs.GetInt(SCORE_SAVE_KEY,_score.CurrentScore);
        }
    }
}