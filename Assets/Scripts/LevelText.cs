using TMPro;
using UnityEngine;

public class LevelText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("LevelText.Start");
        var level = LevelManager.Instance.GetLevel();
        OnLevelChanged(level);
    }

    void Awake()
    {
        Debug.Log("LevelText.Awake");
        LevelManager.Instance.OnLevelChanged += OnLevelChanged;
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
