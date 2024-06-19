using UnityEngine;

public class RotatingObstacle : MonoBehaviour
{
    public float rotationSpeed = 100f; // Y ekseni etraf�nda d�nme h�z�

    void Update()
    {
        // Y ekseni etraf�nda belirli bir h�zla d�nd�rme i�lemi
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}
