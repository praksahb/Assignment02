using UnityEngine;

namespace BasketCollector
{
    public class BallView : MonoBehaviour
    {

        private Rigidbody2D rigidBody;

        public int SpeedVal { get; set; }

        private void Awake()
        {
            rigidBody = GetComponent<Rigidbody2D>();
        }


        private void FixedUpdate()
        {

            rigidBody.MovePosition(rigidBody.position + (Vector2.down * SpeedVal * Time.deltaTime));
        }
    }
}
