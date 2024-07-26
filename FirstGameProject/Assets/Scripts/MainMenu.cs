using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public void PlayGame()
    {
        // Load the GameScene
        SceneManager.LoadScene("Endless Cube");
    }

    // Works if clicked the "Quit" button
    public void QuitGame()
    {
        Debug.Log("Exit the Game!");
        Application.Quit();
    }
}
