using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveHealthOnCollide : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Hero Submarine"))
        {
            other.gameObject.GetComponent<Health>().health -= 2;
        }
    }
}
