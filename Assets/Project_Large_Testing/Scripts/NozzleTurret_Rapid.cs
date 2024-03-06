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
	public class NozzleTurret_Rapid : MonoBehaviour 
	{
        [SerializeField] GameObject turretProjectilePrefab;
        [SerializeField] Transform turretProjectileSpawnPoint1;
        [SerializeField] float timer = 1f;
        [SerializeField] GameObject player;

        void Start()
        {
            player = GameObject.FindGameObjectWithTag("Hero Submarine");
        }

        void Update()
        {
            float distance = Vector2.Distance(transform.position, player.transform.position);
            //Debug.Log(distance);

            if(distance < 50)
            {
                timer += Time.deltaTime;

                if (timer > 1)
                {
                    timer = 0;
                    FireTurretRapidProjectile();
                }
            }
        }

        void FireTurretRapidProjectile()
        {
            Instantiate(turretProjectilePrefab, turretProjectileSpawnPoint1.position, Quaternion.identity);
        }

    }
}