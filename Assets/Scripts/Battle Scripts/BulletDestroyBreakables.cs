using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EthanRoche;

namespace EthanRoche
{
	/// <summary>
	/// Author: Ethan Roche
	/// Description: This script demonstrates how to destroy breakables in Unity
	/// </summary>
	
	public class BulletDestroyBreakables : MonoBehaviour 
	{
        //This script attaches to the bullet prefab, and detects colliding with objects tagged as "Breakable" and destroying them
		private void OnTriggerEnter(Collider other)
        {
			if(other.gameObject.CompareTag("Breakable"))
            {
				Destroy(other.gameObject);
            }
        }
    }
}