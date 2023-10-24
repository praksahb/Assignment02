using UnityEngine;

namespace BasketCollector.Collectibles

{
    public class BallView : MonoBehaviour
    {
        public BallController BallController { get; set; }
        public int SpeedVal { get; set; }

        private ValueTracker valueUI;
        private Rigidbody2D rigidBody;

        private void Awake()
        {
            rigidBody = GetComponent<Rigidbody2D>();
            valueUI = GetComponentInChildren<ValueTracker>();
        }

        private void FixedUpdate()
        {
            rigidBody.MovePosition(rigidBody.position + (SpeedVal * Time.deltaTime * Vector2.down));
        }


        public void SetBallValue(int value)
        {
            if (valueUI != null)
            {
                valueUI.SetValue(value);
            }
        }

        public void SetObjectActive(bool val)
        {
            gameObject.SetActive(val);
        }
    }
}
