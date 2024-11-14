using System.IO;
using Core;
using ScoreSystem;
using UnityEngine;

namespace SaveSystem
{
    public class JsonSaver : ISaver, IService
    {
        private readonly Score _score;
        
        public JsonSaver(Score score)
        {
            _score = score;
        }
        
        public void SaveScore(string path = null)
        {
            ScoreData scoreData = new ScoreData(_score.CurrentScore);
          
            string objJson = JsonUtility.ToJson(scoreData);
            File.WriteAllText(Application.persistentDataPath + path, objJson);
        }

        public int LoadScore(string path = null)
        {
            string savePath = Application.persistentDataPath + path;
            if (File.Exists(savePath))
            {
                string loadedScoreData = File.ReadAllText(savePath);
                ScoreData scoreData = JsonUtility.FromJson<ScoreData>(loadedScoreData);
                Debug.Log(scoreData.Score);
                return scoreData.Score;
            }

            return 0;
        }
    }
}