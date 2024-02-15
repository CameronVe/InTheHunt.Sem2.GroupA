using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tristan;

namespace Tristan
{
	/// <summary>
	/// Author: Tristan McKay
	/// Description: This script is for the missile silo, it spawns the missiles
	/// </summary>

	public class SpawnMissile : MonoBehaviour 
	{
		[SerializeField] float spawnMissileEveryThisSeconds = 0;
		float time = 0;
		[SerializeField] GameObject Missile;
		[SerializeField] float DepthToSpawnMissile = -18;

		Vector3 spawnLocation;

        private void Start()
        {
            spawnLocation = new Vector3(gameObject.transform.position.x, DepthToSpawnMissile, gameObject.transform.position.z);
        }

        private void Update()
        {
            if (time > spawnMissileEveryThisSeconds)
			{
				time = 0;

                Instantiate(Missile, spawnLocation, Quaternion.identity);
			}
			else
			{
				time += Time.deltaTime;
			}
        }
    }
}