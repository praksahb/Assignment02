using TMPro;
using UnityEngine;

namespace BasketCollector
{
    // Stores/Modifies value of the ball collectibles

    public class ValueTracker : MonoBehaviour
    {
        private TMPro.TextMeshProUGUI valueText;

        private void Awake()
        {
            valueText = GetComponent<TextMeshProUGUI>();
        }

        public void SetValue(int value)
        {
            valueText.SetText(value.ToString());
        }
    }
}
