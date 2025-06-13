using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // передвижение персонажf
    public Rigidbody2D rb;

    public KeyCode moveUpKey = KeyCode.W;
    public KeyCode moveLeftKey = KeyCode.A;
    public KeyCode moveDownKey = KeyCode.S;
    public KeyCode moveRightKey = KeyCode.D;

    public float speedX;
    public float speedY;
    public float jump;




    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
        }

        if (Input.GetKey(moveLeftKey))
        {
            speedX = - 0.1f;
        }

        if (Input.GetKey(moveDownKey))
        {
            speedY = -0.1f;
        }

        if (Input.GetKey(moveRightKey))
        {
            speedX = 0.1f;
        }

        transform.Translate(speedX, speedY, 0);
        speedX = 0;
        speedY = 0;

    }










}
