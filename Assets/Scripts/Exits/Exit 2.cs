using UnityEngine;

public class Exit2 : MonoBehaviour
{
    public Transform player;
    public Transform spawnPoint3;

    public float distance;

    public void Update()
    {
        distance = Vector2.Distance(player.transform.position, transform.position);
        if (distance <= 3)
        {
            if (Input.GetKey(KeyCode.E))
            {
                Debug.Log("ÒÅËÅÏÎÐÒ ÍÀ ËÎÊÀÖÈÞ 3");
                player.transform.position = spawnPoint3.position;
            }
        }
    }
}
