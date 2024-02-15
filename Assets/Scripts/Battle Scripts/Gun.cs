using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Matthew;

namespace Matthew
{
    ///<summary>
    ///Author: Matthew Hamm, Modified by Tristan Mckay
    ///Script for GunScriptHolder.
    ///Fire buttons are left ctrl, mouse 0 and joystick button 0
    ///</summary>
    
    public class Gun : MonoBehaviour
    {
        #region CommentedOut
        //Gun[] guns;                                         // Array to store all Gun components in child objects

        //int currentGunIndex = 0;                            // Index to track the current gun to shoot

        //[SerializeField] bool top;
        //[SerializeField] bool forward;
        //[SerializeField] bool bottom;
        #endregion CommentedOut

        bool shootForward;                 // Flag to determine if the gun should shoot
        bool shootTop;                     // Flag to determine if the gun should shoot
        bool shootBottom;                  // Flag to determine if the gun should shoot

        [SerializeField] bool topGun;
        [SerializeField] bool forwardGun;
        [SerializeField] bool bottomGun;

        [SerializeField] Transform topGunTrasform;
        [SerializeField] Transform forwardGunTrasform;
        [SerializeField] Transform bottomGunTrasform;

        [SerializeField] Bullet bulletTop;                     // Bullet prefab to be instantiated
        [SerializeField] Bullet bulletForward;                     // Bullet prefab to be instantiated
        [SerializeField] Bullet bulletBottom;                     // Bullet prefab to be instantiated

        [SerializeField] float shootForwardCooldown = 1f;   // Time delay between shots
        [SerializeField] float shootTopCooldown = 1f;       // Time delay between shots
        [SerializeField] float shootBottomCooldown = 1f;    // Time delay between shots

        float shootForwardtimer;                            // Timer to control the shooting frequency
        float shootToptimer;                                // Timer to control the shooting frequency
        float shootBottomtimer;                             // Timer to control the shooting frequency

        int count;                                          //Makes sure multiple bullets don't fire at once from the same gun.

        void Start()
        {
            //guns = GetComponentsInChildren<Gun>(); // Get all Gun components in child objects
        }

        void Update()
        {
            CheckTime(ref shootToptimer, shootTopCooldown, ref shootTop, bulletTop);

            CheckTime(ref shootForwardtimer, shootForwardCooldown, ref shootForward, bulletForward);

            CheckTime(ref shootBottomtimer, shootBottomCooldown, ref shootBottom, bulletBottom);


            shootTop = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.Mouse1) || Input.GetKey(KeyCode.Joystick1Button3);
            shootForward = Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.Mouse0) || Input.GetKey(KeyCode.Joystick1Button1);
            shootBottom = Input.GetKey(KeyCode.C) || Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.Joystick1Button0);
        }

        //Made the bullet timer into a method to split it into the three guns we need.
        public void CheckTime(ref float theTimer, float whatCooldown,ref bool theGun, Bullet theBullet)
        {
            // Check if enough time has passed to allow shooting
            if (theTimer >= whatCooldown)
            {
                if (theGun == true && count == 0)
                {
                    theGun = false;
                    //guns[currentGunIndex].Shoot(theBullet); // Shoot only from the current gun

                    gameObject.GetComponent<Gun>().Shoot(theBullet);

                    theTimer = 0; // Reset the timer after shooting

                    // Update the index to the next gun
                    //currentGunIndex = (currentGunIndex + 1) % guns.Length;
                    count++;
                }
            }
            else
            {
                count = 0;
                theTimer += Time.deltaTime; // Increase the timer based on the time passed in the frame
            }
        }

        public void Shoot(Bullet theBullet)
        {
            if (topGun == true)
            {
                Instantiate(theBullet.gameObject, topGunTrasform.position, Quaternion.identity);
            }

            if (forwardGun == true)
            {
                Instantiate(theBullet.gameObject, forwardGunTrasform.position, Quaternion.identity);
            }

            if (bottomGun == true)
            {
                Instantiate(theBullet.gameObject, bottomGunTrasform.position, Quaternion.identity);
            }
        }
    }
}