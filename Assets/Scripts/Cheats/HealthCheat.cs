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

	public class HealthCheat : MonoBehaviour 
	{
        int count;

        void Start ()
		{
			count = 0;
        }

		public void Update()
		{
			if (Input.GetKeyDown(KeyCode.Semicolon) && Input.GetKeyDown(KeyCode.Quote))
			{
				count = 1;
			}

			if (count == 1)
			{
				count++;
                GameObject player = GameObject.FindGameObjectWithTag("Hero Submarine");
                player.GetComponent<Health>().health = 999_999_999;
				Debug.Log("; ' were pushed");
            }
        }
	}
}