using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tristan;
using System;

namespace Tristan
{
	/// <summary>
	/// Author: Tristan McKay
	/// Description: This script is in progress
	/// </summary>

	public class ResetCountDownTimer : MonoBehaviour 
	{
		[SerializeField] TimeKeeper timeKeeper;
		
        private void OnTriggerEnter(Collider other)
        {
			timeKeeper.timer = 0.0f;
        }
    }
}