/// <summary>
///Author: Matthew Hamm
///Script for bullet Speed and destroys the bullet when it moves out of frame.
/// </summary>
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Vector2 direction = new Vector2(1, 0); // Direction in which the bullet will move
    public float speed = 8; // Speed of the bullet
    public Vector2 velocity; // Current velocity of the bullet

    private Camera mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate the velocity based on the given direction and speed
        velocity = direction * speed;

        MoveBullet();
    }

    private void MoveBullet()
    {
        Vector2 pos = transform.position;

        // Update the position based on the velocity and deltaTime
        pos += velocity * Time.deltaTime;

        transform.position = pos;

        CheckIfOutsideCameraBounds();
    }

    private void CheckIfOutsideCameraBounds()
    {
        if (!mainCamera)
            return;

        Vector3 viewportPosition = mainCamera.WorldToViewportPoint(transform.position);

        // Check if the object is outside the camera bounds
        if (viewportPosition.x < 0 || viewportPosition.x > 1 || viewportPosition.y < 0 || viewportPosition.y > 1)
        {
            Destroy(gameObject);
        }
    }
}
