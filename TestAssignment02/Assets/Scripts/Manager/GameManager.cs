using BasketCollector.Collectibles;
using BasketCollector.PlayerMovement;
using BasketCollector.UI;
using UnityEngine;

namespace BasketCollector
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private TimerController timerController;
        [SerializeField] private BallGenerator ballGenerator;
        [SerializeField] private PlayerController playerController;
        [SerializeField] private GameStartPanel gameStartPanel;
        [SerializeField] private GameOverPanel gameOverPanel;

        private void Awake()
        {
            timerController.GameManager = this;
            gameStartPanel.GameManager = this;
            gameOverPanel.GameManager = this;
        }

        private void Start()
        {
            LoadStartMenu();
        }

        public void StartGame(GameData gameData)
        {
            gameStartPanel.gameObject.SetActive(false);
            // setup/ load start values
            timerController.TimerValue = gameData.totalTime;
            timerController.StartTimer = true;

            ballGenerator.BallSetTimer = gameData.ballLaunchTimer;
            ballGenerator.BallSpeed = gameData.ballSpeed;
            ballGenerator.IsCreatingBalls = true;

            playerController.MoveSpeed = gameData.playerMovementSpeed;
            // start the game
        }

        public void StopGame()
        {
            timerController.StartTimer = false;
            ballGenerator.IsCreatingBalls = false;
            playerController.MoveSpeed = 0;
            gameOverPanel.SetScore(playerController.GetScore());
            gameOverPanel.gameObject.SetActive(true);
        }

        public void LoadStartMenu()
        {
            gameOverPanel.gameObject.SetActive(false);
            gameStartPanel.gameObject.SetActive(true);

            timerController.StartTimer = false;
        }
    }
}
