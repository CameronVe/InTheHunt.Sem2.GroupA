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
	public class FinTurret_Rapid_Back : MonoBehaviour 
	{
        [SerializeField] GameObject turretProjectilePrefab;
        [SerializeField] Transform turretProjectileSpawnPoint1;
        [SerializeField] float timer = 1f;
        [SerializeField] GameObject player;

        void Start()
        {
            StartCoroutine(SpawnDelay());
            player = GameObject.FindGameObjectWithTag("Hero Submarine");
        }

        IEnumerator SpawnDelay()
        {
            yield return new WaitForSeconds(1.5f);
            Update();
        }

        void Update()
        {
            float distance = Vector2.Distance(transform.position, player.transform.position);
            //Debug.Log(distance);

            if (distance < 50)
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