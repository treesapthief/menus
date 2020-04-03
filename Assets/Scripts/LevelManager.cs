
using UnityEngine;

public delegate void OnLevelChangedHandler(int level);
public class LevelManager : MonoBehaviour
{
    public event OnLevelChangedHandler OnLevelChanged;
    private int _currentLevel = 1;

    public static LevelManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null || Instance != this)
        {
            Instance = this;
        }

        DontDestroyOnLoad(Instance.gameObject);
    }

    public void SetLevel(int level)
    {
        _currentLevel = level;
        //if (_currentLevel > NumberOfLevels)
        //{
        //    _currentLevel = NumberOfLevels;
        //}

        Debug.Log($"OnLevelChanged: {_currentLevel}");
        OnLevelChanged?.Invoke(_currentLevel);
        //BuildLevel(_currentLevel);
    }

    public int GetLevel()
    {
        return _currentLevel;
    }
}
