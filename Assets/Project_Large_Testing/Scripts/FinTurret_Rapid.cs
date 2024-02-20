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
	public class FinTurret_Rapid : MonoBehaviour 
	{
        [SerializeField] GameObject turretProjectilePrefab;
        [SerializeField] Transform turretProjectileSpawnPoint1;
        [SerializeField] float timer = 1f;
        [SerializeField] float distanceBeforeFire = 50;
        [SerializeField] GameObject player;

        void Start()
        {
            player = GameObject.FindGameObjectWithTag("Hero Submarine");
        }

        void Update()
        {
            float distance = Vector2.Distance(transform.position, player.transform.position);
            //Debug.Log(distance);

            if(distance < distanceBeforeFire)
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