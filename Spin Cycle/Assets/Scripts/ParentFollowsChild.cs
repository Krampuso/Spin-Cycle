using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentFollowsChild : MonoBehaviour
{
    public Transform[] childObjects; // Array to hold references to the child objects

    private Vector2 initialOffset;

    void Start()
    {
        if (childObjects.Length == 0)
        {
            Debug.LogError("No child objects assigned.");
            return;
        }

        // Calculate the initial offset between the parent and the average position of the children
        Vector2 averageChildPosition = GetAverageChildPosition();
        initialOffset = (Vector2)transform.position - averageChildPosition;
    }

    void LateUpdate()
    {
        if (childObjects.Length > 0)
        {
            // Update the parent's position to follow the average position of the children
            Vector2 averageChildPosition = GetAverageChildPosition();
            transform.position = (Vector3)(averageChildPosition + initialOffset);
        }
    }

    // Helper method to calculate the average position of all child objects
    private Vector2 GetAverageChildPosition()
    {
        Vector2 sumPositions = Vector2.zero;

        foreach (Transform child in childObjects)
        {
            sumPositions += (Vector2)child.position;
        }

        return sumPositions / childObjects.Length;
    }
}