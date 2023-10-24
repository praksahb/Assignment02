using UnityEngine;
using UnityEngine.UI;

namespace BasketCollector
{
    public class GameStartPanel : MonoBehaviour
    {
        [SerializeField] private Slider gameTimerSlider;
        [SerializeField] private Slider ballTimerSlider;
        [SerializeField] private Slider ballSpeedSlider;
        [SerializeField] private Slider playerMoveSpeedSlider;

        private Button startButton;

        private void Awake()
        {
            startButton = GetComponent<Button>();
        }

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


        }

    }
}
