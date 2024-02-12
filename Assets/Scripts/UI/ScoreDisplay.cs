using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tristan;
using TMPro;

namespace Tristan
{
	/// <summary>
	/// Author: Tristan McKay
	/// Description: This script demonstrates how to ... in Unity
	/// </summary>

	public class ScoreDisplay : MonoBehaviour 
	{
        PlayerScore score;
        [SerializeField] TextMeshProUGUI scoreText;

        private void Start()
        {
            score = FindFirstObjectByType<PlayerScore>();
        }

        private void Update()
        {
            scoreText.text = score.score.ToString("00000000");
        }
    }
}