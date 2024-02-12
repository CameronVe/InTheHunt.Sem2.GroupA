using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tristan;

namespace Tristan
{
	/// <summary>
	/// Author: Tristan McKay
	/// Description: This script demonstrates how to ... in Unity
	/// </summary>

	public class FreezeTimer : MonoBehaviour 
	{
        [SerializeField] TimeKeeper timeKeeper;

        private void OnTriggerEnter(Collider other)
        {
            timeKeeper.isFrozen = true;
        }
    }
}