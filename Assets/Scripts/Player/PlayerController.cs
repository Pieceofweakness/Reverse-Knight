using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // передвижение персонажа

    public KeyCode moveUpKey = KeyCode.W;
    public KeyCode moveLeftKey = KeyCode.A;
    public KeyCode moveDownKey = KeyCode.S;
    public KeyCode moveRightKey = KeyCode.D;

    public float speedX;
    public float speedY;


    private void Start()
    {
    }

    private void Update()
    {
        if (Input.GetKey(moveUpKey))
        {
            speedY = 0.1f;
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
