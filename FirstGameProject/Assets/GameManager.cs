using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 2f; // Bekleme süresi

    public GameObject CompleteLevelUI;

    public void CompleteLevel()
    {
        CompleteLevelUI.SetActive(true);
    }

    public void GameOver()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            PlayerPrefs.SetString("LastScene", SceneManager.GetActiveScene().name); // keep current scene in the memory
            Invoke("LoadGameOverScene", restartDelay); // wait 2 sec and load GameOver scene
        }
    }

    void LoadGameOverScene()
    {
        SceneManager.LoadScene("GameOver"); // "GameOver" scene load
    }

    public void Retry()
    {
        string lastScene = PlayerPrefs.GetString("LastScene");
        SceneManager.LoadScene(lastScene); // Load the last scene
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu"); 
    }

    public void QuitGame()
    {
        Debug.Log("Quitting the game!");
        Application.Quit();
    }
}
