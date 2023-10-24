using UnityEngine;

namespace BasketCollector.Collectibles
{
    public class BallController
    {
        public BallModel BallModel { get; }
        public BallView BallView { get; }

        public BallController(BallModel ballModel, BallView ballPrefab, System.Tuple<int, int> boundary, Transform spawnPoint)
        {
            BallModel = ballModel;

            BallView = Object.Instantiate(ballPrefab, SpawnPosition(boundary, spawnPoint.position.y), Quaternion.identity, spawnPoint);
            BallView.BallController = this;
            BallView.SetBallValue(BallModel.Value);
        }

        public void SetBallSpeed(int speed)
        {
            BallView.SpeedVal = speed;
        }


        private Vector2 SpawnPosition(System.Tuple<int, int> boundary, float YPosition)
        {
            float XPosition = Random.Range(boundary.Item1, boundary.Item2 + 1);

            return new Vector2(XPosition, YPosition);
        }
    }
}
