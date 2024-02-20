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
                GameObject player = GameObject.FindGameObjectWithTag("Hero Submarine");
				if (player.GetComponent<Health>().health < 10)
				{
					player.GetComponent<Health>().health = 14;
                }
                //Debug.Log("Health Cheat is On");
            }
        }
	}
}