using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tristan;
using Matthew;

namespace Tristan
{
    /// <summary>
    /// Author: Tristan McKay, inspired by Matthew Hamm's Gun Script
    /// Description: This script is the shooting script, it contains a transform
    ///              where the bullet will spawn and the input's it will take to
    ///              spawn the bullet (depending on which bool you turn to true).
    /// </summary>


    public class NewGun : MonoBehaviour
    {
        bool playerInput;                                   // Flag to determine if the gun should shoot

        [SerializeField] bool topGun;                       //Tick this if the bullet will be fired from the top so it uses that input
        [SerializeField] bool forwardGun;                   //Tick this if the bullet will be fired from the front so it uses that input
        [SerializeField] bool bottomGun;                    //Tick this if the bullet will be fired from the bottom so it uses that input

        [SerializeField] public float bulletCooldown = 0.5f;       // Time delay between shots
        float bulletTimer;                                  // Timer to control the shooting frequency

        [SerializeField] Matthew.Bullet bullet;             // Bullet prefab to be instantiated

        [SerializeField] Transform bulletSpawnLocation;

        int count;                                          //Makes sure multiple bullets don't fire at once from the same gun.

        void Update()
        {
            // Check if enough time has passed to allow shooting
            if (bulletTimer >= bulletCooldown)
            {
                if (playerInput == true && count == 0)
                {
                    playerInput = false;

                    gameObject.GetComponent<NewGun>().Shoot(bullet);

                    bulletTimer = 0; // Reset the timer after shooting
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
