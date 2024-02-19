using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraMovementSystem : MonoBehaviour
{
    public Transform target;
    private float largestXPosition;
    [SerializeField] float largestYPosition;
    [SerializeField] float smallestYPosition;

    private void Start()
    {
        // Initialize the largestXPosition to the initial position of the target object.
        largestXPosition = target.position.x;
    }

    private void Update()
    {
        // Get the current position of the target object.
        float targetX = target.position.x;

        // Update the largestXPosition if the target has moved further.
        if (targetX > largestXPosition)
        {
            largestXPosition = targetX;
        }

        // Get the current position of the follower object.
        Vector3 currentPosition = transform.position;

        // Update the follower's position only on the x and y axis.
        // The z position remains unchanged.
        currentPosition.x = largestXPosition;
        currentPosition.y = target.position.y; // Follow the target on the y-axis.

        if (currentPosition.y > largestYPosition)
        {
            currentPosition.y = largestYPosition;
        }
        else if (currentPosition.y < smallestYPosition)
        {
            currentPosition.y = smallestYPosition;
        }

        if (currentPosition.x > 1599)
        {
            currentPosition.x = 1599;
        }

        // Update the follower's position.
        transform.position = currentPosition;
    }
}
