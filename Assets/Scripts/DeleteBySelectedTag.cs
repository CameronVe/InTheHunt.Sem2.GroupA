using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBySelectedTag : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            GameObject parent = other.GetComponentInParent<Transform>().gameObject;
            Destroy(parent);
        }
        Debug.Log("Hit");
    }
}
