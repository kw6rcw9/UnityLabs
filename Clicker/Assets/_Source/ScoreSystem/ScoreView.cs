
using System;
using TMPro;

using UnityEngine;

namespace ScoreSystem
{
    public class ScoreView : MonoBehaviour
    {
        [SerializeField] private TMP_Text scoreText;
        private Score _score;
        

        public void Construct(Score score)
        {
            _score = score;
        }
        

        private void OnEnable()
        {
            
            _score.OnScoreChange += RefreshScoreText;
           
        }

        private void OnDisable()
        {
            _score.OnScoreChange -= RefreshScoreText;
        }

        private void RefreshScoreText(int currentScore)
        {
            scoreText.text = $"Score: {currentScore}";
        }
    }
}
