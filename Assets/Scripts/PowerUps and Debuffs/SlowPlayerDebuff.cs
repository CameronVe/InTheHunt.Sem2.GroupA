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

    public class SlowPlayerDebuff : MonoBehaviour
    {
        bool hasHit;

        GameObject player;

        [SerializeField] float debuffTime = 5;
        float timer;
        private void OnTriggerEnter(Collider other)
        {
            

            if(other.tag != "Enemy")
            {
                player = other.gameObject;
                other.GetComponent<PlayerMovement>().moveSpeed = 6;
                gameObject.transform.localScale = Vector3.zero;

                hasHit = true;
            }
        }

        private void Update()
        {
            if(hasHit)
            {
                if (timer > debuffTime)
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