namespace BasketCollector
{
    public class GameData
    {
        public int totalTime;
        public int ballLaunchTimer;
        public int ballSpeed;
        public int playerMovementSpeed;

        public GameData(int totalTime, int ballLaunchTimer, int ballSpeedTimer, int playerMovementSpeed)
        {
            this.totalTime = totalTime;
            this.ballLaunchTimer = ballLaunchTimer;
            this.ballSpeed = ballSpeedTimer;
            this.playerMovementSpeed = playerMovementSpeed;
        }
    }
}
