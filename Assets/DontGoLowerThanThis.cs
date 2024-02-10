using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontGoLowerThanThis : MonoBehaviour
{
    [SerializeField] float lowestPoint;
    [SerializeField] float highestPoint;
    //[SerializeField] float furthestForward;

    // Update is called once per frame
    void Update()
    {

        //this just makes it stop at a certain y position (basically Mathf.Clamp(), but didn't work for some reason).
        if (transform.position.y > highestPoint)
        {
            transform.position = new Vector3(transform.position.x, highestPoint, transform.position.z);
        }

        //this just makes it stop at a certain y position (basically Mathf.Clamp(), but didn't work for some reason).
        if (transform.position.y < lowestPoint)
        {
            transform.position = new Vector3(transform.position.x, lowestPoint, transform.position.z);
        }
    }
}
