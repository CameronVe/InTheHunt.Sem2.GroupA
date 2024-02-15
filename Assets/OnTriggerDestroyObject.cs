using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tristan;

namespace Tristan
{
    /// <summary>
    /// Author: Tristan McKay
    /// Description: This script turns the object on a spline track when it reaches the end
    ///				 and then sets the carts speed to a negative or a positve depending on
    ///				 the direction.
    /// </summary>

    public class OnTriggerDestroyObject : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            Destroy(other.gameObject);
        }
    }
}
