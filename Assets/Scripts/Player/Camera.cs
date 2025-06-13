using UnityEngine;

public class Camera : MonoBehaviour
{

    public Transform player;
    public Vector3 Target;

    public float TrackingSpeed;


    private void Start()
    {
        
    }

    void Update()
    {
        TrackingSpeed = 1.25f;
        if (player)
        {
            Vector3 currentPosition = Vector3.Lerp(transform.position, Target, TrackingSpeed * Time.deltaTime);
            transform.position = currentPosition;

            Target = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
        }


    }
}
