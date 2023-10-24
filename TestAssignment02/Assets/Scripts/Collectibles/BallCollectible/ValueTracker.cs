using TMPro;
using UnityEngine;

namespace BasketCollector
{
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
