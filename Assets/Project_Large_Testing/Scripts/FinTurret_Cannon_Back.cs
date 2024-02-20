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
	public class FinTurret_Cannon_Back : MonoBehaviour 
	{
        [SerializeField] GameObject turretProjectilePrefab;
        [SerializeField] Transform turretProjectileSpawnPoint1;
        [SerializeField] float timer = 3f;
        [SerializeField] float distanceBeforeFire = 50;
        private GameObject player;

        void Start()
        {
            StartCoroutine(SpawnDelay());
            player = GameObject.FindGameObjectWithTag("Hero Submarine");
        }

        //IEnumerator SpawnDelay()
        //{
        //    yield return new WaitForSeconds(3f);
        //    Update();
        //}

        void Update()
        {                    
            float distance = Vector2.Distance(transform.position, player.transform.position);
            //Debug.Log(distance);

            //if (distance < 25)
            //{
            //    StartCoroutine(SpawnDelay());
            //}

                if (distance < distanceBeforeFire)
                {
                    timer += Time.deltaTime;

                    if (timer > 1)
                    {
                        timer = 0;
                        FireTurretCannonProjectile();
                    }
                }
        }

        IEnumerator SpawnDelay()
        {
            yield return new WaitForSeconds(3f);
        }

        void FireTurretCannonProjectile()
        {
            Instantiate(turretProjectilePrefab, turretProjectileSpawnPoint1.position, Quaternion.identity);
        }

    }
}