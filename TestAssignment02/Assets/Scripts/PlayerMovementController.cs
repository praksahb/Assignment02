using UnityEngine;

namespace BasketCollector.PlayerMovement
{
    public class PlayerMovementController : MonoBehaviour
    {
        [SerializeField] private float moveSpeed;

        private Rigidbody2D rigidBody;

        private float moveHorizontal;
        private Vector2 moveDirection;

        private void Awake()
        {
            rigidBody = GetComponent<Rigidbody2D>();
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
    }
}
