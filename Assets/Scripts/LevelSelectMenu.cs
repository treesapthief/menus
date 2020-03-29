using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectMenu : MonoBehaviour
{
    public int NumberOfLevels = 20;

    public void PlayGame()
    {
        Debug.Log("Play Game");
        SceneManager.LoadScene("GameScene");
    }

    public void LoadLevels()
    {
        // TODO: Dynamically add buttons to screen based on NumberOfLevels
    }
}
