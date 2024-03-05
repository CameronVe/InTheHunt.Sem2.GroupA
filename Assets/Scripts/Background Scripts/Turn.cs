using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn : MonoBehaviour
{
    public static Turn instance;

    [SerializeField] float spinSpeed = 60; //How fast the item spins (so this is 60 degrees every frame).
    [SerializeField] public static float spin = 0f; //Just a value to use as the transform.rotation in the GetAnimation Script to make the item spin.

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        Spin();
    }

    public void Spin()
    {
        //This is for the items rotation (so it's 360 degrees)
        if (spin > 360f)
        {
            spin = 0f; //Resets the spin value to zero so the value doesn't get bloated.
        }
        else
        {
            spin += Time.deltaTime * spinSpeed;
        }
    }
}
