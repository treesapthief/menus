using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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
        var children = GameObject.FindGameObjectsWithTag("LevelSelectButton");

        // Clear out children in content
        foreach (var childObject in children)
        {
            Destroy(childObject.gameObject);
        }

        for (var i = 0; i < NumberOfLevels; i++)
        {
            var buttonPrefab = Instantiate(LevelButton, ViewPortContent.transform);
            var button = buttonPrefab.GetComponent<Button>();
            var level = i + 1;
            button.onClick.AddListener(delegate { SelectLevel(level); });
            var text = buttonPrefab.GetComponentInChildren<TMP_Text>();
            text.text = $"Level {i + 1}";
        }
    }

    private void SelectLevel(int level)
    {
        LevelManager.Instance.SetLevel(level);
        SceneManager.LoadScene("GameScene");
    }
}
