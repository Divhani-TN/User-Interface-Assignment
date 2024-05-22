using System.Collections.Generic;
using UnityEngine;
public class Snap : MonoBehaviour
{

    public Drag[] draggableObjects; // Array of draggable objects
    public Transform[] SnapAreas; // Array of snap areas
    public float snapRange = 5f; // The maximum range within which snapping will occur
    internal bool haschildren = false;

    private void Start()
    {
        // Assign the OnDragEnded callback to each draggable object
        foreach (Drag draggable in draggableObjects)
        {
            if (draggable != null)
            {
                draggable.dragEndedCallback = OnDragEnded;
            }
            else
            {
                Debug.LogError("One or more draggable objects in the draggableObjects list is null.");
            }
        }
    }

    private void OnDragEnded(Drag draggable)
    {
        float closestDistance = float.MaxValue; // Initialize with maximum float value
        Transform closestSnapArea = null;

        // Loop through each SnapArea to find the closest one
        foreach (Transform snapArea in SnapAreas)
        {
            float currentDistance = Vector2.Distance(draggable.transform.position, snapArea.position); // Use world position for distance calculation
            if (currentDistance < closestDistance)
            {
                closestSnapArea = snapArea;
                closestDistance = currentDistance;
            }
        }

        // Snap the draggable to the closest snap area if within snap range
        if (closestSnapArea != null && closestDistance <= snapRange)
        {
            draggable.transform.position = closestSnapArea.position; // Snap using world position
            // Optional: Align rotation and scale if needed
            draggable.transform.rotation = closestSnapArea.rotation;
            draggable.transform.localScale = closestSnapArea.localScale;
        }
    }
}
