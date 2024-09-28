using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    public float movementSpeed = 10f;
    float movement = 0f;
    Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        movement =  Input.GetAxis("Horizontal") * movementSpeed;
        FlipDoodler();
    }
    void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = movement;
        rb.velocity = velocity;
    }
    void FlipDoodler()
    {
        if (movement < 0)
            transform.localScale = new Vector3(-1f, 1f, 1f);
        else if (movement > 0)
            transform.localScale = new Vector3(1f, 1f, 1f);
    }
}
