using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    //[SerializeField] private Transform groundCheck;
    //[SerializeField] private BoxCollider2D _collider;
    //[SerializeField] private LayerMask groundMask;
    public float speed = 5f;
    public float deceleration = 0.25f;
    private float dampingFactor;
    private float vertical;
    private float lastV;
    private bool isMoving;

    //public float rayDistance;
    //[SerializeField] private float jumpLeapDistance;
    //public bool isJumping;
    //public bool isGrounded;
    //public int jumpDistance = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //void Start()
    //{
    //    //rb = GetComponent<Rigidbody2D>();
    //}

    private void Update()
    {
        //Debug.Log(Input.GetKeyDown(KeyCode.Space));
        vertical = Input.GetAxisRaw("Vertical");
        // Player Jump Movement
        //isJumping = Input.GetButtonDown("Jump");
        //if (isJumping) { 
        //    rayDistance = _collider.bounds.extents.y + jumpLeapDistance;
        //    isGrounded = Physics2D.Raycast(transform.position, Vector2.down, rayDistance, groundMask).collider; 
        //    if (isGrounded)
        //    {
        //        rb.AddForce(Vector2.up * jumpDistance, ForceMode2D.Impulse);
        //        isJumping = isGrounded = false;
        //    }
        //}
    }


    void FixedUpdate()
    {
        // Vertical movement of player with Slide effect
        if (vertical != 0) {
            rb.linearVelocityY = vertical * speed;
            dampingFactor = speed;
            isMoving = true;
            lastV = vertical;
        }
        else if (vertical == 0 && isMoving) {
            rb.linearVelocityY = dampingFactor * lastV;
            dampingFactor -= deceleration;
            //rayDistance = _collider.bounds.extents.y + jumpLeapDistance;
            //isGrounded = Physics2D.Raycast(transform.position, Vector2.down, rayDistance, groundMask).collider;
            if (dampingFactor <= 0) {
                rb.linearVelocityY = 0;
                isMoving = false;
            }
        }

    }
}