using UnityEngine;
using UnityEngine.UI;

namespace BasketCollector.UI
{
    public class GameStartPanel : MonoBehaviour
    {
        [SerializeField] private Slider gameTimerSlider;
        [SerializeField] private Slider ballTimerSlider;
        [SerializeField] private Slider ballSpeedSlider;
        [SerializeField] private Slider playerMoveSpeedSlider;
        [SerializeField] private Button startButton;

        public GameManager GameManager { get; set; }


        private void OnEnable()
        {
            startButton.onClick.AddListener(StartGame);
        }

        private void OnDisable()
        {
            startButton.onClick.RemoveAllListeners();
        }

        private void StartGame()
        {
            // close this panel and start the game with the values taken from the slider.
            int totalTimer = (int)gameTimerSlider.value;
            int BallLaunchTimer = (int)ballTimerSlider.value;
            int ballSpeed = (int)ballSpeedSlider.value;
            int playerMoveSpeed = (int)playerMoveSpeedSlider.value;

            GameData newGameData = new GameData(totalTimer, BallLaunchTimer, ballSpeed, playerMoveSpeed);

            // handle game start and close/open panels with gameManager with or without UIManager for small scoped project
            GameManager.StartGame(newGameData);
        }

    }
}
