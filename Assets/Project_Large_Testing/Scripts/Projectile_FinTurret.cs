using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JonathanBannister;

namespace JonathanBannister
{
    //2D Enemy Shooting Unity Tutorial (Projectile tracks player)
    //https://www.youtube.com/watch?v=--u20SaCCow&t=9s
    
    /// <summary>
	/// Author: Jonathan Bannister
	/// Description: This script demonstrates how to ... in Unity
	/// </summary>
	public class Projectile_FinTurret : MonoBehaviour 
	{
        private GameObject player;
        private Rigidbody rigidbody;
        public float force;
        public float projectileTimer;
        //public float projectileLife = 1;

        void Start()
        {
            //Destroy(gameObject, projectileLife);
            rigidbody = GetComponent<Rigidbody>();
            player = GameObject.FindGameObjectWithTag("Hero Submarine");

            Vector3 direction = player.transform.position - transform.position;
            rigidbody.velocity = new Vector3(direction.x, direction.y, direction.z).normalized * force;

            float turretProjectileRotation = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;
            //transform.rotation = Quaternion.Euler(0, turretProjectileRotation - 90, 0);
            transform.rotation = Quaternion.Euler(turretProjectileRotation, 270, 0);
        }

        //void Update()
        //{
        //    projectileTimer += Time.deltaTime;

        //    if(projectileTimer > 10)
        //    {
        //        Destroy(gameObject);
        //    }
        //}

        void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.CompareTag("Hero Submarine"))
            {
                Destroy(gameObject);
            }

            if(other.gameObject.CompareTag("Barrier"))
            {
                Destroy(gameObject);
            }
        }
    }
}