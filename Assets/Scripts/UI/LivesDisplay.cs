using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tristan;

namespace Tristan
{
	/// <summary>
	/// Author: Tristan McKay
	/// Description: This script is in progress
	/// </summary>

	public class LivesDisplay : MonoBehaviour 
	{
		[SerializeField] GameObject livesHolder;
        [SerializeField] GameObject[] livesInHolder;
        [SerializeField] Health health;

		int startCount;

        private void Start()
        {
			startCount = 0;

            foreach (var live in livesInHolder)
			{
				livesInHolder[startCount] = live;
				startCount++;
            }

   //         for (int i = 0; i > health.health; i++)
			//{

			//}
        }
    }
}