using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JonathanBannister;

namespace JonathanBannister
{
    //3D Platformer in unity - Enemy Shooting tutorial (NavMesh)
    //https://www.youtube.com/watch?v=k1kOtaM2NJg&t=7s 

    //Simple Shooting - First person/Key input
    //https://www.youtube.com/watch?v=EwiUomzehKU


    /// <summary>
    /// Author: Jonathan Bannister
    /// Description: This script demonstrates how to ... in Unity
    /// </summary>
    public class FinTurret_Cannon : MonoBehaviour
    {
        [SerializeField] GameObject turretProjectilePrefab;
        [SerializeField] Transform turretProjectileSpawnPoint1;
        [SerializeField] float timer = 3f;
        private GameObject player;

        void Start()
        {
            player = GameObject.FindGameObjectWithTag("Hero Submarine");
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
                    FireTurretCannonProjectile();
                }
            }
        }

        void FireTurretCannonProjectile()
        {
            Instantiate(turretProjectilePrefab, turretProjectileSpawnPoint1.position, Quaternion.identity);
        }
    }
}