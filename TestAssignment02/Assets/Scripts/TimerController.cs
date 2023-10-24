using UnityEngine;

namespace BasketCollector
{
    public class TimerController : MonoBehaviour
    {
        private TMPro.TextMeshProUGUI timerText;
        private float timerValue;
        private int timerValueInt;

        public float TimerValue
        {
            get { return timerValue; }
            set
            {
                timerValue = value;
            }
        }
        public bool StartTimer { get; set; }
        public GameManager GameManager { get; set; }

        private void Awake()
        {
            timerText = GetComponent<TMPro.TextMeshProUGUI>();
        }

        private void Update()
        {
            if (StartTimer)
            {

                if (timerValue <= 0)
                {
                    timerValue = 0;
                    timerValueInt = 0;
                    SetText(timerValueInt);
                    // end the game.
                    GameManager.StopGame();
                }
                else
                {
                    timerValue -= Time.deltaTime;
                    timerValueInt = (int)(timerValue % 60);
                    SetText(timerValueInt);
                }
            }
        }

        private void SetText(int value)
        {
            timerText.SetText(value.ToString());
        }

    }
}
