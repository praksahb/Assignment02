using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace BasketCollector
{
    public class SliderValues : MonoBehaviour
    {
        [SerializeField] private Slider textSlider;
        private TextMeshProUGUI textValue;

        private void Awake()
        {
            textValue = GetComponent<TextMeshProUGUI>();
        }
        private void Start()
        {
            SetTextValue(textSlider.value);
        }

        public void SetTextValue(float value)
        {
            textValue.SetText(value.ToString());
        }
    }
}
