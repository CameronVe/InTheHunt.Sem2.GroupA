using System.Collections;
using System.Collections.Generic;
using Tristan;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class Health : MonoBehaviour
{
    [SerializeField] GameObject parent;
    public int health = 1;
    public int scoreOnDeath = 1;
    [SerializeField] bool isBoss;
    [SerializeField] bool isPlayer;
    bool check = true;
    PlayerScore score;

    private void Start()
    {
        score = FindFirstObjectByType<PlayerScore>();
    }

    void Update()
    {
        if (health <= 0 && isPlayer == true)
        {
            SceneManager.LoadScene("GameOver");
        }

        if (health <= 0 && isBoss == true)
        {
            SceneManager.LoadScene("WinScreen");
        }

        if (health <= 0)
        {
            if (check == true && isPlayer == false)
            {
                check = false;
                score.score += scoreOnDeath;
            }
            Destroy(gameObject);
            Destroy(parent);
        }
    }
}
