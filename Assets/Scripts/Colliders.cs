using UnityEngine;

public class Colliders : MonoBehaviour
{
    public Transform player;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if(gameObject.tag == "LeftCollider")
            {
                player.position = new Vector3(player.position.x + 5f, player.position.y, player.position.z);
            }
            if (gameObject.tag == "RightCollider")
            {
                player.position = new Vector3(player.position.x - 5f, player.position.y, player.position.z);
            }
        }
    }
}
