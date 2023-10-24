using System;
using UnityEngine;

namespace BasketCollector.Collectibles
{
    public class BallGenerator : MonoBehaviour
    {
        [SerializeField] private BallView ballPrefab;
        [SerializeField] private float yPosition;
        [SerializeField] private float timerVal;
        [SerializeField] private int ballSpeedVal;
        [SerializeField] private Transform spawnPoint;


        private bool isCreatingBalls;
        private float timerOriginal;

        private void Awake()
        {
            isCreatingBalls = true;
            timerOriginal = timerVal;
        }

        private void Update()
        {
            if (isCreatingBalls)
            {
                timerVal -= Time.deltaTime;

                if (timerVal <= 0)
                {
                    timerVal = timerOriginal;

                    GenerateBall();
                }
            }

        }

        private void GenerateBalls()
        {
            BallView ball = Instantiate(ballPrefab);
            float XPosition = UnityEngine.Random.Range(-8, 9);
            ball.transform.position = new Vector2(XPosition, yPosition);
            ball.SpeedVal = ballSpeedVal;
        }

        private void GenerateBall()
        {
            int value = UnityEngine.Random.Range(-5, 6);

            BallModel ballModel = new BallModel(value);
            Tuple<int, int> boundary = new Tuple<int, int>(-8, 8);
            BallController ballController = new BallController(ballModel, ballPrefab, boundary, spawnPoint);
            ballController.SetBallSpeed(ballSpeedVal);
        }

    }
}
