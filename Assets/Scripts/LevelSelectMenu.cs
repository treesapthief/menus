using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectMenu : MonoBehaviour
{
    public int NumberOfLevels = 20;
    public GameObject ViewPortContent;
    public GameObject LevelButton;

    public void PlayGame()
    {
        Debug.Log("Play Game");
        SceneManager.LoadScene("GameScene");
    }

    public void Start()
    {
        LoadLevels();
    }

    public void LoadLevels()
    {
        // BUG: This is not deleting the correct items
        var children = ViewPortContent.GetComponentsInChildren<Transform>();

        // Clear out children in content
        //foreach (var childObject in children)
        //{
        //    Destroy(childObject.gameObject);
        //}

        for (var i = 0; i < NumberOfLevels; i++)
        {
            var button = Instantiate(LevelButton, ViewPortContent.transform);
            var text = button.GetComponentInChildren<TMP_Text>();
            text.text = $"Level {i + 1}";
        }

        // TODO: Expand the content width based on # of levels
    }
}
