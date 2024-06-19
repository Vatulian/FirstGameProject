using UnityEngine;

public class MovingObstacle : MonoBehaviour
{
    public float moveSpeed = 5f; // Hareket h�z�
    public float moveDistance = 3f; // Hareket mesafesi

    private Vector3 startPosition; // Ba�lang�� pozisyonu
    private bool movingRight = true; // Hareket y�n�

    void Start()
    {
        startPosition = transform.position; // Ba�lang�� pozisyonunu kaydet
    }

    void Update()
    {
        // Engelin sa�a ve sola hareket etmesini sa�la
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
