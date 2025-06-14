using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // передвижение персонажf
    public Rigidbody2D rb;
    public Transform foots;
    public LayerMask Ground;

    public KeyCode moveUpKey = KeyCode.Space;
    public KeyCode moveLeftKey = KeyCode.A;
    public KeyCode moveRightKey = KeyCode.D;

    public float speedX;
    public float speedY;

    public float jump;
    public bool onGround;
    
    public float checkRadius = 0.5f;
    




    private void Start()
    {
        moveUpKey = KeyCode.Space;
        moveLeftKey = KeyCode.A;
        moveRightKey = KeyCode.D;
        jump = 200f;
        checkRadius = 0.5f;
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Walking();

        Jump();

        CheckingGround();

        

    }

    public void Walking()
    {
        if (Input.GetKey(moveLeftKey))
        {
            speedX = -0.1f;
        }

        if (Input.GetKey(moveRightKey))
        {
            speedX = 0.1f;
        }

        transform.Translate(speedX, speedY, 0);
        speedX = 0;
        speedY = 0;
    }

    public void Jump()
    {
        if (Input.GetKey(moveUpKey) && onGround)
        {
            rb.AddForce(Vector2.up * jump);
        }
    }

    public void CheckingGround()
    {
        onGround = Physics2D.OverlapCircle(foots.position, checkRadius, Ground);
    }









}
