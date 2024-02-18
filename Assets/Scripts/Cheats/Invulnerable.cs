using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tristan;

namespace Tristan
{
    /// <summary>
    /// Author: Tristan McKay
    /// Description: This script makes the player invulnerable by changing the players tag,
    ///              in doing so the enemies bullets will not hit the player making them
    ///              "invulnerable".
    /// </summary>


    public class Invulnerable : MonoBehaviour
    {

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.LeftBracket) && Input.GetKeyDown(KeyCode.RightBracket))
            {
                Invulnerability();
            }
        }

        private void Invulnerability()
        {
            GameObject player = GameObject.FindWithTag("Hero Submarine");
            player.tag = "Invulnerable";
            Debug.Log("Now invulnerable");
        }
    }
}
