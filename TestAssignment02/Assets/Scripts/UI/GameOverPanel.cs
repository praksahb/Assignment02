using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace BasketCollector.UI
{
    public class GameOverPanel : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI scoreText;
        [SerializeField] private Button backButton;

        public GameManager GameManager { get; set; }

        private void OnEnable()
        {
            backButton.onClick.AddListener(BackFunction);
        }

        private void OnDisable()
        {
            backButton.onClick.RemoveAllListeners();
        }

        private void BackFunction()
        {
            GameManager.LoadStartMenu();
        }

        public void SetScore(int value)
        {
            scoreText.SetText("Score: " + value.ToString());
        }
    }
}
