using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnObject : MonoBehaviour
{
    [SerializeField] float spinSpeed = 60; //How fast the item spins (so this is 60 degrees every frame).
    [SerializeField] public static float spin = 0f; //Just a value to use as the transform.rotation in the GetAnimation Script to make the item spin.

    [SerializeField] bool rotateX;
    [SerializeField] bool rotateY;
    [SerializeField] bool rotateZ;

    float x;
    float y;
    float z;

    private void Start()
    {
        x = gameObject.transform.localRotation.x;
        y = gameObject.transform.localRotation.y;
        z = gameObject.transform.localRotation.z;
    }

    void Update()
    {
        if (rotateX == true)
        {
            gameObject.transform.localRotation = Quaternion.Euler(spin, y, z);
        }

        if (rotateY == true)
        {
            gameObject.transform.localRotation = Quaternion.Euler(x, spin, z);
        }

        if (rotateZ == true)
        {
            gameObject.transform.localRotation = Quaternion.Euler(x, y, spin);
        }

        Spin();
    }

    void Spin()
    {
        //This is for the items rotation (so it's 360 degrees)
        if (spin > 360f)
        {
            spin = 0f; //Resets the spin value to zero so the value doesn't get bloated.
        }
        else
        {
            spin += Time.fixedDeltaTime * spinSpeed;
        }
    }
}
