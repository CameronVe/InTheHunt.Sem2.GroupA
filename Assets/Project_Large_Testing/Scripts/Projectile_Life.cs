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
	public class Projectile_Life : MonoBehaviour 
	{
		public float projectileLife = 1;

		void Update()
        {
			Destroy(gameObject, projectileLife);
		}
	}
}