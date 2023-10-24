namespace BasketCollector
{
    public class GameData
    {
        public int totalTime;
        public int ballLaunchTimer;
        public int ballSpeedTimer;
        public int playerMovementSpeed;

        public GameData(int totalTime, int ballLaunchTimer, int ballSpeedTimer, int playerMovementSpeed)
        {
            this.totalTime = totalTime;
            this.ballLaunchTimer = ballLaunchTimer;
            this.ballSpeedTimer = ballSpeedTimer;
            this.playerMovementSpeed = playerMovementSpeed;
        }
    }
}
