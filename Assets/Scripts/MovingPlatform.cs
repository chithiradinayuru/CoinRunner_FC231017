
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float distance = 3f;
    public float speed = 1f;

    private Vector2 startPosition;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startPosition = rb.position;
    }

    void FixedUpdate()
    {
        float x = Mathf.PingPong(
            Time.time * speed,
            distance
        );

        rb.MovePosition(
            startPosition + Vector2.right * x
        );
    }
}
