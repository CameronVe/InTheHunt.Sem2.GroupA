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
	public class Nozzle_Turret_Shooting : MonoBehaviour 
	{
        //private GameObject player;
        private Rigidbody rigidbody;
        public float force;
        //private Transform target;
        //public float projectileTimer;

        void Start()
        {
            rigidbody = GetComponent<Rigidbody>();
            //player = GameObject.FindGameObjectWithTag("Player");


            Vector3 direction = -transform.right;
            //Vector3 direction = target.transform.forward - transform.position;
            //rigidbody.velocity = new Vector3(direction.x, direction.y, direction.z).normalized * force;
            rigidbody.velocity = new Vector3(direction.x, direction.y, direction.z).normalized * force;
            //rigidbody.velocity = -transform.right * force;

            float turretProjectileRotation = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;
            //transform.rotation = Quaternion.Euler(0, turretProjectileRotation - 90, 0);
            transform.rotation = Quaternion.Euler(turretProjectileRotation, -90, 0);
        }

        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Hero Submarine"))
            {
                Destroy(gameObject);
            }

            if (other.gameObject.CompareTag("Barrier"))
            {
                Destroy(gameObject);
            }
        }
    }

}