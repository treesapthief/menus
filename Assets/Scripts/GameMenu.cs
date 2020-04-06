using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GameMenu : MonoBehaviour, IDeselectHandler
{
    public GameObject MenuPanel;

    //private Button _button;

    private void Start()
	{
	}

    public void OnDeselect(BaseEventData data)
    {
        Debug.Log("Deselected");
        // TODO: Also check to see if action/click is within the MenuPanel
        CloseMenu();
    }

    public void ToggleMenu()
	{
        var isActive = MenuPanel.activeSelf;
        MenuPanel.SetActive(!isActive);
	}

    public void OpenMenu()
	{
        MenuPanel.SetActive(true);
	}

    public void CloseMenu()
	{
        MenuPanel.SetActive(false);
	}
}
