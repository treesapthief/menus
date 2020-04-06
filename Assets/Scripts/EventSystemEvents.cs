using System;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(EventSystem))]
public class EventSystemEvents : MonoBehaviour
{
    public static event Action<GameObject, GameObject> OnSelectionUpdated;

    [SerializeField]
    private EventSystem _eventSystem;
    private GameObject _lastSelectedGameObject;
    
    private static void DispatchSelectionUpdated(GameObject newSelectedGameObject, GameObject previousSelectedGameObject)
    {
        Debug.Log("OnSelectionUpdated");
        OnSelectionUpdated?.Invoke(newSelectedGameObject, previousSelectedGameObject);
    }


    private void Update()
    {
        var currentSelectedGameObject = _eventSystem.currentSelectedGameObject;
        if (currentSelectedGameObject != _lastSelectedGameObject)
        {
            DispatchSelectionUpdated(currentSelectedGameObject, _lastSelectedGameObject);
            _lastSelectedGameObject = currentSelectedGameObject;
        }
    }
}