using System.Collections;
using System.Collections.Generic;
using Tristan;
using UnityEngine;

namespace Tristan
{
    /// <summary>
    /// Author: Tristan McKay
    /// Description: This script sets the player bullet fire rate to 0.1 
    ///              (makes bullets shoot more often)
    /// </summary>


    public class BulletRapidFireCheat : MonoBehaviour
    {
        [SerializeField] NewGun[] gunlist;

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Period) && Input.GetKeyDown(KeyCode.Slash))
            {
                RapidFireCheat();
            }
        }

        private void RapidFireCheat()
        {
            foreach (var gun in gunlist)
            {
                gun.bulletCooldown = 0.1f;
            }
            Debug.Log("Rapid Fire Cheat is On");
        }
    }
}