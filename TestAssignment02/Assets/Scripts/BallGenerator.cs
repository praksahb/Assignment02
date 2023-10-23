using UnityEngine;

namespace BasketCollector.GenerateBalls
{
    public class BallGenerator : MonoBehaviour
    {
        [SerializeField] private BallView ballPrefab;
        [SerializeField] private float YPosition;
        [SerializeField] private float timerVal;
        [SerializeField] private int ballSpeedVal;


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

        private void GenerateBall()
        {
            BallView ball = Object.Instantiate(ballPrefab);
            float XPosition = Random.Range(-8, 9);
            ball.transform.position = new Vector2(XPosition, YPosition);
            ball.SpeedVal = ballSpeedVal;
        }



    }
}
