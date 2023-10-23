using UnityEngine;

namespace BasketCollector.PlayerMovement
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float moveSpeed;

        private ScoreController scoreTracker;

        private Rigidbody2D rigidBody;

        private float moveHorizontal;
        private Vector2 moveDirection;

        private void Awake()
        {
            rigidBody = GetComponent<Rigidbody2D>();
            scoreTracker = GetComponentInChildren<ScoreController>();
        }

        // Update is called once per frame
        void Update()
        {
            moveHorizontal = Input.GetAxis("Horizontal");
        }

        private void FixedUpdate()
        {
            moveDirection.x = moveHorizontal * moveSpeed * Time.fixedDeltaTime;
            rigidBody.MovePosition(rigidBody.position + moveDirection);
        }

        private void OnTriggerEnter2D(Collider2D collider)
        {
            if (collider.TryGetComponent(out BallView ball))
            {
                scoreTracker.IncreaseScore();
                Destroy(ball.gameObject);
            }
        }
    }
}
