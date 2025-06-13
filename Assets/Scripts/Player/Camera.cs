using UnityEngine;

public class Camera : MonoBehaviour
{
    internal static readonly object current;
    public Transform player;
    public Vector3 Target;

    public float TrackingSpeed = 2f;

    void Update()
    {
        if (player)
        {
            Vector3 currentPosition = Vector3.Lerp(transform.position, Target, TrackingSpeed * Time.deltaTime);
            transform.position = currentPosition;

            Target = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
        }


    }
}
