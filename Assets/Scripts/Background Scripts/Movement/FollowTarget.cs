using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    [SerializeField] Transform objectToFollow;
    [SerializeField] float furthestForward = -100;
    // Update is called once per frame
    void Update()
    {
        //this just makes it stop at a certain y position (basically Mathf.Clamp(), but didn't work for some reason).
        if (transform.position.x > furthestForward)
        {
            furthestForward = transform.position.x;
            transform.position = new Vector3(furthestForward, transform.position.y, transform.position.z);
        }
        transform.position = objectToFollow.position;
    }
}
