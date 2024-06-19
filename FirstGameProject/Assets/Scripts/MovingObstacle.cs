using UnityEngine;

public class MovingObstacle : MonoBehaviour
{
    public float moveSpeed = 5f; // Hareket hýzý
    public float moveDistance = 3f; // Hareket mesafesi

    private Vector3 startPosition; // Baþlangýç pozisyonu
    private bool movingRight = true; // Hareket yönü

    void Start()
    {
        startPosition = transform.position; // Baþlangýç pozisyonunu kaydet
    }

    void Update()
    {
        // Engelin saða ve sola hareket etmesini saðla
        if (movingRight)
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;

            if (transform.position.x >= startPosition.x + moveDistance)
            {
                movingRight = false;
            }
        }
        else
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;

            if (transform.position.x <= startPosition.x - moveDistance)
            {
                movingRight = true;
            }
        }
    }
}
