using UnityEngine;

public class Death : MonoBehaviour
{
    //������������ ������ ��� ������� ������ �� ������ 1
    public Transform player;
    public Transform spawnPoint1;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("�������� ��������������");
            player.transform.position = spawnPoint1.position;
        }
        
    }


}
