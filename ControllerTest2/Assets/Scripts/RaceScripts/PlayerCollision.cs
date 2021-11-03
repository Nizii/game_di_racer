using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Car player;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("We hit Obstacle");
            player.TakeDamage(5);
        }
        
    }
}
