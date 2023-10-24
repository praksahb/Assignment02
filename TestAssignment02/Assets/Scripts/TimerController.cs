using UnityEngine;

namespace BasketCollector
{
    public class TimerController : MonoBehaviour
    {
        private TMPro.TextMeshProUGUI timerText;
        private float timerValue;
        private int timerValueInt;

        private void Awake()
        {
            timerText = GetComponent<TMPro.TextMeshProUGUI>();
            timerValue = 10f;
        }

        private void Update()
        {
            if (timerValue <= 0)
            {
                // end the game.
            }

            timerValue -= Time.deltaTime;
            timerValueInt = (int)(timerValue % 60);
            SetText(timerValueInt);

        }

        private void SetText(int value)
        {
            timerText.SetText(value.ToString());
        }

    }
}
