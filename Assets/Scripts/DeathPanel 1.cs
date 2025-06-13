using UnityEngine;

public class Death : MonoBehaviour
{
    public Transform player;
    public Transform spawnPoint1;

    public float distance;

    void Update()
    {
        distance = Vector3.Distance(player.transform.position, transform.position);

        if (distance <= 4)
        {
            Debug.Log("PIZDAAAAA");
            player.transform.position = spawnPoint1.position;
        }


        
    }

}
