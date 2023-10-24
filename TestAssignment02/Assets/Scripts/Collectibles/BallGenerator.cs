using System;
using UnityEngine;

namespace BasketCollector.Collectibles
{
    public class BallGenerator : MonoBehaviour
    {
        [SerializeField] private BallView ballPrefab;
        [SerializeField] private Transform spawnPoint;

        private float timerOriginal;
        private float timerVal;
        public float BallSetTimer
        {
            get { return timerVal; }
            set
            {
                timerVal = value;
                timerOriginal = value;
            }
        }

        private int ballSpeedVal;
        public int BallSpeed
        {
            get { return ballSpeedVal; }
            set
            {
                ballSpeedVal = value;
            }
        }

        private bool isCreatingBalls;
        public bool IsCreatingBalls
        {
            get { return isCreatingBalls; }
            set
            {
                isCreatingBalls = value;
            }
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
