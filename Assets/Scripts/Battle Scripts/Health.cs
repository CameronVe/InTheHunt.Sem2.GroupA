using System.Collections;
using System.Collections.Generic;
using Tristan;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField] GameObject parent;
    GameObject[] powerupsToDrop;
    Transform powerupsHolder;

    public int health = 1;
    public int scoreOnDeath = 1;

    [SerializeField] bool isBoss;
    [SerializeField] bool isPlayer;

    bool check = true;

    PlayerScore score;

    private void Start()
    {
        powerupsHolder = GameObject.FindWithTag("PowerupHolder").transform;

        if (!isPlayer && !isBoss)
        {
            powerupsToDrop = new GameObject[powerupsHolder.childCount];

            // Iterate through each child and adds it to the array

            for (int i = 0; i < powerupsHolder.childCount; i++)
            {
                Transform child = powerupsHolder.GetChild(i);
                powerupsToDrop[i] = child.gameObject;
            }
        }

        score = FindFirstObjectByType<PlayerScore>();
    }

    void Update()
    {
        if (health <= 0 && isPlayer)
        {
            SceneManager.LoadScene("GameOver");
        }

        if (health > 14 && isPlayer)
        {
            health = 14;
        }

        if (health <= 0 && isBoss)
        {
            SceneManager.LoadScene("WinScreen");
        }

        if (health <= 0)
        {
            if (check)
            {
                check = false;
                score.score += scoreOnDeath;

                int doISpawn = Random.Range(0, 100);
                if (doISpawn > 60)
                {
                    int whatPowerupAmI = Random.Range(0, powerupsToDrop.Length);
                    Instantiate(powerupsToDrop[whatPowerupAmI], gameObject.transform.position, Quaternion.identity);
                }
            }
            Destroy(gameObject);
            Destroy(parent);
        }
    }
}
