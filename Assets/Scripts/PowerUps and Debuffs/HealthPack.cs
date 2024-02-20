using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tristan;
using Matthew;

namespace Tristan
{
    /// <summary>
    /// Author: Tristan McKay
    /// Description: This script demonstrates how to ... in Unity
    /// </summary>

    public class HealthPack : MonoBehaviour
    {

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Hero Submarine"))
            {
                other.GetComponent<Health>().health += 1;
                Destroy(gameObject);
            }
        }
    }
}