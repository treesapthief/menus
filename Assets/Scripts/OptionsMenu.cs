using UnityEngine;

public class OptionsMenu : MonoBehaviour
{
    public void ChangeVolume(float value)
    {
        Debug.Log($"Volume changed: {value}");

    }

    public void SetScreenSize(int screenSize)
    {
        Debug.Log("Set Screen Size");
        switch (screenSize)
        {
            case 1:
                Screen.SetResolution(1024, 768, FullScreenMode.Windowed);
                break;
            case 2:
                Screen.SetResolution(1200, 800, FullScreenMode.Windowed);
                break;
            case 3:
                Screen.SetResolution(1600, 900, FullScreenMode.Windowed);
                break;
        }
    }
}
