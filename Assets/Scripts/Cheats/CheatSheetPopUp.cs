using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tristan;

namespace Tristan
{
    /// <summary>
    /// Author: Tristan McKay
    /// Description: This script sets the cheat sheet Button to active
    ///              allowing the user to view all cheat buttons
    /// </summary>


    public class CheatSheetPopUp : MonoBehaviour
    {
        [SerializeField] GameObject cheatSheetButton;

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Comma) && Input.GetKeyDown(KeyCode.Period))
            {
                CheatSheetShow();
            }
        }

        private void CheatSheetShow()
        {
            cheatSheetButton.SetActive(true);
        }
    }
}
