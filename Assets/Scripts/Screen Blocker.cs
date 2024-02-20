using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Splines;

public class ScreenBlocker : MonoBehaviour
{
    [SerializeField] float offsetXPosition;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Hero Submarine")
        {
            float newPosition = transform.position.x + offsetXPosition;
            other.transform.position = new Vector3(newPosition, other.transform.position.y, 0);
        }
    }
}
