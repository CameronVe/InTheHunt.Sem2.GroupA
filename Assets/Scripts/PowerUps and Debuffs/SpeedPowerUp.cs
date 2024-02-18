using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tristan;
using Matthew;

namespace Tristan
{
    /// <summary>
    /// Author: Tristan McKay
    /// Description: This script demonstrates how to ... in Unity
    /// </summary>

    public class SpeedPowerUp : MonoBehaviour
    {
        bool hasHit;

        GameObject player;

        [SerializeField] float buffTime = 5;
        float timer;
        private void OnTriggerEnter(Collider other)
        {
            if (other.tag != "Enemy")
            {
                player = other.gameObject;
                other.GetComponent<PlayerMovement>().moveSpeed = 18;
                gameObject.transform.localScale = Vector3.zero;

                hasHit = true;
            }
        }

        private void Update()
        {
            if (hasHit)
            {
                if (timer > buffTime)
                {
                    player.GetComponent<PlayerMovement>().moveSpeed = 12;
                    Destroy(gameObject);
                }
                else
                {
                    timer += Time.deltaTime;
                }
            }
        }
    }
}