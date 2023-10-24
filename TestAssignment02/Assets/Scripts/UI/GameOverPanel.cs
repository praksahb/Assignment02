using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace BasketCollector
{
    public class GameOverPanel : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI ScoreText;
        [SerializeField] private Button backButton;


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
            // go back to the settings/ play game menu

        }
    }
}
