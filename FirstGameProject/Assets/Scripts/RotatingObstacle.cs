using UnityEngine;

public class RotatingObstacle : MonoBehaviour
{
    public float rotationSpeed = 100f; // Y ekseni etrafýnda dönme hýzý

    void Update()
    {
        // Y ekseni etrafýnda belirli bir hýzla döndürme iþlemi
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}
