using UnityEngine;

public class DeathPanel2 : MonoBehaviour
{
    public Transform player;
    public Transform spawnPoint2;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("衔型迂世 杖日杖杖日日日");
            player.transform.position = spawnPoint2.position;
        }

    }
}
