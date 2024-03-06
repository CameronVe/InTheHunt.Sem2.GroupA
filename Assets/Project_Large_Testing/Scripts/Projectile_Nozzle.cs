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
	public class Projectile_Nozzle : MonoBehaviour 
	{
		public float Speed = 0.5f;

		void Update()
		{
			transform.position += Vector3.forward * Time.deltaTime * Speed;
		}

	}
}