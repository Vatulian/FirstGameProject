using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    // This function runs when we hit another object.
    // We get information about the collision and call it "collisionInfo".
    void OnCollisionEnter(Collision collisionInfo)
    {
        // We check if we collide with an obstacle.
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false; // Disable player movement.
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
