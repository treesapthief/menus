using TMPro;
using UnityEngine;

public class LevelText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("LevelText.Start");
        var levelManager = LevelManager.Instance;
        if (levelManager != null)
        {
            var level = levelManager.GetLevel();
            OnLevelChanged(level);
        }
    }

    void Awake()
    {
        Debug.Log("LevelText.Awake");
        var levelManager = LevelManager.Instance;
        if (levelManager != null)
        {
            levelManager.OnLevelChanged += OnLevelChanged;
        }
    }

    private void OnLevelChanged(int level)
    {
        var text = GetComponent<TMP_Text>();
        text.text = $"Level {level}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
