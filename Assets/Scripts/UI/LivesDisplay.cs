using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tristan;

namespace Tristan
{
	/// <summary>
	/// Author: Tristan McKay
	/// Description: This script is used for displaying the health, 
    ///              it gets the icons (GameObjects) in the parent 
    ///              and stores them into a GameObject array.
    ///              It then turns off all of the icons and then 
    ///              tuns on the icons that we need based on the 
    ///              health value of the object with the health script.
	/// </summary>

	public class LivesDisplay : MonoBehaviour 
	{
		[SerializeField] Transform livesHolder;
        [SerializeField] GameObject[] livesInHolder;
        [SerializeField] Health health;

        int storedHealth;

        private void Start()
        {
            storedHealth = health.health;

            livesInHolder = new GameObject[livesHolder.childCount];

            // Iterate through each child and adds it to the array

            for (int i = 0; i < livesHolder.childCount; i++)
            {
                Transform child = livesHolder.GetChild(i);
                livesInHolder[i] = child.gameObject;
            }

            UpdateHealthDisplayHealth();
        }

        private void Update()
        {
            // If the health value is less than storedHealth,
            // update the storedHealth with the new value
            // and update the display.

            if (health.health < storedHealth)
            {
                storedHealth = health.health;
                UpdateHealthDisplayHealth();
            }

            // If the health value is more than storedHealth,
            // update the storedHealth with the new value
            // and update the display.

            if (health.health > storedHealth)
            {
                storedHealth = health.health;
                UpdateHealthDisplayHealth();
            }
        }

        private void UpdateHealthDisplayHealth()
        {
            // Sets all objects to false

            for (int i = 0; i < livesHolder.childCount; i++)
            {
                livesInHolder[i].SetActive(false);
            }

            // Turns on the ones we need

            for (int i = 0; i < health.health; i++)
            {
                if (i > livesHolder.childCount)
                {
                    break;
                }
                else
                {
                    livesInHolder[i].SetActive(true);
                }
            }
        }
    }
}