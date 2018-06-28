using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScoreSystem
{
    public class ScoreManager : MonoBehaviour
    {
        private static uint _score;
        private static uint _scoreMultiplier;

        public static uint Score
        {
            get { return _score; }
        }

        public static uint ScoreMultiplier
        {
            get { return _scoreMultiplier; }
        }

        private void Awake()
        {
            LoadValues();
        }

        void LoadValues()
        {
            _score = (uint) PlayerPrefs.GetInt("Score");
            _scoreMultiplier = (uint)PlayerPrefs.GetInt("Multiplier");
            if (_scoreMultiplier == 0)
                _scoreMultiplier = 1;
        }

        public static void SaveValues()
        {
            PlayerPrefs.SetInt("Score", (int) _score);
            PlayerPrefs.SetInt("Multiplier", (int)_scoreMultiplier);
        }

        public static void SetScoreMultiplier(uint newMultiplier)
        {
            _scoreMultiplier = newMultiplier;
        }

        public static void AddScore(uint scoreAmount)
        {
            _score += scoreAmount * _scoreMultiplier;
        }

        public static void RemoveScore(uint scoreAmount)
        {
            _score -= scoreAmount;
        }

        private void OnApplicationQuit()
        {
            SaveValues();
        }
    }
}
