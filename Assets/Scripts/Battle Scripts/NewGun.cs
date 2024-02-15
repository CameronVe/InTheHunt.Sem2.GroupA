using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tristan;
using Matthew;

namespace Tristan
{
    /// <summary>
    /// Author: Tristan McKay
    /// Description: This script is for the missile silo, it spawns the missiles
    /// </summary>


    public class NewGun : MonoBehaviour
    {
        bool playerInput;

        [SerializeField] bool topGun;
        [SerializeField] bool forwardGun;
        [SerializeField] bool bottomGun;

        [SerializeField] float bulletCooldown = 0.5f;
        float bulletTimer;

        [SerializeField] Matthew.Bullet bullet;                     // Bullet prefab to be instantiated

        [SerializeField] Transform bulletSpawnLocation;

        int count;                                          //Makes sure multiple bullets don't fire at once from the same gun.

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            // Check if enough time has passed to allow shooting
            if (bulletTimer >= bulletCooldown)
            {
                if (playerInput == true && count == 0)
                {
                    playerInput = false;
                    //guns[currentGunIndex].Shoot(theBullet); // Shoot only from the current gun

                    gameObject.GetComponent<NewGun>().Shoot(bullet);

                    bulletTimer = 0; // Reset the timer after shooting

                    // Update the index to the next gun
                    //currentGunIndex = (currentGunIndex + 1) % guns.Length;
                    count++;
                }
            }
            else
            {
                count = 0;
                bulletTimer += Time.deltaTime; // Increase the timer based on the time passed in the frame
            }

            if (topGun)
            {
                playerInput = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.Mouse1) || Input.GetKey(KeyCode.Joystick1Button3);
            }
            else if (forwardGun)
            {
                playerInput = Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.Mouse0) || Input.GetKey(KeyCode.Joystick1Button1);
            }
            else if (bottomGun)
            {
                playerInput = Input.GetKey(KeyCode.C) || Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.Joystick1Button0);
            }
        }

        public void Shoot(Matthew.Bullet theBullet)
        {
            Instantiate(theBullet.gameObject, bulletSpawnLocation.position, Quaternion.identity);
        }
    }
}
