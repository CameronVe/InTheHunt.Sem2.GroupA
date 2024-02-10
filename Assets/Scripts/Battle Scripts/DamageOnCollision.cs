using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// this script will be attached to the missiles, default on enemy missiles
/// </summary>

public class DamageOnCollision : MonoBehaviour
{
    // tag to be changed when attached to hero missiles
    public string detectedTag = "Hero Submarine";

    void OnTriggerEnter(Collider whatWasHit)
    {
        if (whatWasHit.CompareTag(detectedTag)==true)
        {
            //this line takes health from the object with the detectedTag
            whatWasHit.GetComponent<Health>().health -= 1;

            //this line destroys the missile the script is attached to
            Destroy(gameObject);
        }
       
    }
}
