using UnityEngine;

public class Exit1 : MonoBehaviour
{
    public Transform player;
    public Transform spawnPoint2;
    public Transform camera;
    public Transform cameraPos;

    public float distance;
    public void Start()
    {
        
    }

    public void Update()
    {
        distance = Vector2.Distance(player.transform.position, transform.position);
        if (distance <= 3)
        {
            if (Input.GetKey(KeyCode.E))
            {
                Debug.Log("ÒÅËÅÏÎÐÒ ÍÀ ËÎÊÀÖÈÞ 2");
                camera.transform.position = cameraPos.position;
                player.transform.position = spawnPoint2.position;
            }
        }
    }
}
