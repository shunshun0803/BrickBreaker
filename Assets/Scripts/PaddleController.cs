using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(inputX * speed, 0);
    }
}