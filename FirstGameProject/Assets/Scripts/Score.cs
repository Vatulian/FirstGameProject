using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // TextMeshPro interface
    private int scoreCount = 0; // Count collectible

    void Start()
    {
        UpdateScoreText(); 
    }

    public void Collect(GameObject collectible)
    {
        scoreCount++; // increase score
        Debug.Log("Collectible collected! Score: " + scoreCount); // Debug message
        UpdateScoreText();
        Destroy(collectible);
    }

    void UpdateScoreText()
    {
        scoreText.text = "Coins: " + scoreCount; 
    }
}
