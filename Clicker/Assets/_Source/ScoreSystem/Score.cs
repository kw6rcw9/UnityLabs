using System;
using UnityEngine;

namespace ScoreSystem
{
    public class Score
    {
        private const int _startValue = 5;
        private const int _endValue = 0;
        private int _score;

        public Action<int> OnScoreChange;
        private int CurrentScore
        {
            get => _score;


             set
            {
                _score = value;
                OnScoreChange?.Invoke(_score);
            }
        }

        public void ResetScore()
        {
            CurrentScore = _endValue;
            
        }

        public void SetupScore()
        {
            CurrentScore = _startValue;
            Debug.Log(CurrentScore);
        }

        public void IncreaseScore()
        {
            CurrentScore++;
          
        }
        public void DecreaseScore()
        {
            CurrentScore--;
          
        }
    }
}
