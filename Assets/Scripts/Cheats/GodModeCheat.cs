using System.Collections;
using System.Collections.Generic;
using Tristan;
using UnityEngine;

namespace Tristan
{
    /// <summary>
    /// Author: Tristan McKay
    /// Description: This script makes the player invulnerable and makes 
    ///              them fire bullets quicker (more can be added later)
    /// </summary>



    public class GodModeCheat : MonoBehaviour
    {
        [SerializeField] NewGun[] gunlist;

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Tilde) && Input.GetKeyDown(KeyCode.Alpha1))
            {
                RapidFireCheat();
                Invulnerability();
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

        private void Invulnerability()
        {
            GameObject.FindWithTag("Hero Submarine").tag = "Invulnerable";
            Debug.Log("Now invulnerable");
        }
    }
}