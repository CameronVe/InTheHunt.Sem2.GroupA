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
	/// 
	///Front turret rotate piece = Boss_Body_Fin_Left_Turret_Rotate005
	///Back turret rotate piece = Boss_Body_Fin_Left_Turret_Rotate006

	//Unity Documentation - Vector3.RotateTowards
	//https://docs.unity3d.com/ScriptReference/Vector3.RotateTowards.html

	public class TrackPlayer : MonoBehaviour 
	{
		//Target to rotate towards
		public Transform target;
		//Angular speed in radians per second
		public float speed = 1.0f;

		
		//private GameObject player;
		//public GameObject turretRotatePoint;
		//Vector2 Direction;

		void Update()
        {
			Vector3 targetDirection = target.position - transform.position;

			float singleStep = speed * Time.deltaTime;

			Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 0.0f);

            Debug.DrawRay(transform.position, newDirection, Color.red);

            transform.rotation = Quaternion.LookRotation(newDirection);

            //player = GameObject.FindGameObjectWithTag("Player");
            //Vector3 direction = player.transform.position - transform.position;

            //Vector2 targetPos = Target.position;

            //direction = targetPos - (Vector2)transform.position;


            //turretRotatePoint.transform.up = direction; 

        }
	}
}