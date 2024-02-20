using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayerBackInBounds : MonoBehaviour
{
    [SerializeField] float newPosition;
    [SerializeField] bool isFloor;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hero Submarine"))
        {
            if (isFloor == true)
            {
                other.transform.position = new Vector3(other.transform.position.x, newPosition, 0);
            }
            else
            {
                other.transform.position = new Vector3(newPosition, other.transform.position.y, 0);
            }
        }
    }
}
