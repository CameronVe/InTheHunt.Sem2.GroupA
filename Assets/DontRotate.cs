using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontRotate : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        gameObject.transform.rotation = Quaternion.Euler(0,0,0);
    }
}
