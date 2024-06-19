using UnityEngine;

public class ArrowMovement : MonoBehaviour
{
    public float moveSpeed = 5f; 
    public float moveDistance = 3f; 

    private Vector3 startPosition; // Position of start
    private bool movingUp = true; // Direction

    void Start()
    {
        startPosition = transform.position; // Remember first position
    }

    void Update()
    {
        
        if (movingUp)
        {
            transform.position += Vector3.up * moveSpeed * Time.deltaTime;

            if (transform.position.y >= startPosition.y + moveDistance)
            {
                movingUp = false;
            }
        }
        else
        {
            transform.position += Vector3.down * moveSpeed * Time.deltaTime;

            if (transform.position.y <= startPosition.y - moveDistance)
            {
                movingUp = true;
            }
        }
    }
}