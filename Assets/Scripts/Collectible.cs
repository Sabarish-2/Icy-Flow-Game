using UnityEngine;

public class Collectible : MonoBehaviour
{
    private Rigidbody2D rb;
    public float Speed = 1.1f;
    private LevelManager lm;
    private float destroyX;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        lm = GameObject.FindWithTag("UI").GetComponent<LevelManager>();
        rb.linearVelocity = new Vector2(-Speed, 0);

        // Calculate the left edge of the screen in world coordinates
        destroyX = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).x -0.5f;
    }

    private void FixedUpdate()
    {
        if (transform.position.x < destroyX)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (gameObject.CompareTag("Fire"))
            {
                if (lm.health == 0) return;
                lm.health--;
            }
            else if (gameObject.CompareTag("Water"))
            {
                if (lm.health == 5) lm.score += 10;
                else lm.health++;
            }
            Destroy(gameObject);
        }
    }
}