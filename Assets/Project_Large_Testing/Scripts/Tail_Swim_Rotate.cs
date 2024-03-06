using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JonathanBannister;

namespace JonathanBannister
{
	/// <summary>
	/// Author: Jonathan Bannister
	/// Description: This script demonstrates how to ... in Unity
	/// </summary>
	public class Tail_Swim_Rotate : MonoBehaviour 
	{
		public float xAngle, yAngle, zAngle;
		public GameObject bossTail;

		void Update()
        {
			bossTail.transform.Rotate(0f, 5f, 0f);
			bossTail.transform.Rotate(0f, -10f, 0f);
		}

	}
}