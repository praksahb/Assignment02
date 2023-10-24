using TMPro;
using UnityEngine;

namespace BasketCollector
{
    public class ScoreController : MonoBehaviour
    {
        private TextMeshPro scoreText;
        private int scoreVal = 0;

        private void Awake()
        {
            scoreText = GetComponent<TextMeshPro>();
        }

        public void IncreaseScore(int value)
        {
            scoreVal += value;
            scoreText.SetText(scoreVal.ToString());
        }

        public int GetScore()
        {
            return scoreVal;
        }

    }
}
