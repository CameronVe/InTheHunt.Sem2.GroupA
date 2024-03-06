using System.Collections;
using System.Collections.Generic;
using Tristan;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField] GameObject parent;
    GameObject[] powerupsToDrop;
    GameObject[] powerupsToDropAir;
    [SerializeField] GameObject explosion;
    Transform powerupsHolder; 
    Transform powerupsHolderAir;
    [SerializeField] GameObject boss2;

    public int health = 1;
    public int scoreOnDeath = 1;

    [SerializeField] bool isBoss1;
    [SerializeField] bool isBoss2;
    [SerializeField] bool isPuffer;
    [SerializeField] bool isPlayer;
    [SerializeField] bool flying;

    bool check = true;

    PlayerScore score;

    private void Start()
    {
        powerupsHolder = GameObject.FindWithTag("PowerupHolder").transform;
        powerupsHolderAir = GameObject.FindWithTag("PowerupHolderAir").transform;

        if (!isPlayer && !isBoss1 && !flying)
        {
            powerupsToDrop = new GameObject[powerupsHolder.childCount];

            // Iterate through each child and adds it to the array

            for (int i = 0; i < powerupsHolder.childCount; i++)
            {
                Transform child = powerupsHolder.GetChild(i);
                powerupsToDrop[i] = child.gameObject;
            }
        }

        if (flying)
        {
            powerupsToDropAir = new GameObject[powerupsHolderAir.childCount];

            // Iterate through each child and adds it to the array

            for (int i = 0; i < powerupsHolderAir.childCount; i++)
            {
                Transform child = powerupsHolderAir.GetChild(i);
                powerupsToDropAir[i] = child.gameObject;
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

        if (health <= 0 && isBoss2)
        {
            SceneManager.LoadScene("WinScreen");
        }
        if (health <= 0 && isBoss1)
        {
            gameObject.SetActive(false);
            boss2.SetActive(true);
        }

        if (health <= 0 && isPuffer)
        {
            gameObject.transform.localScale = Vector3.zero;
            Instantiate(explosion, transform.position, Quaternion.identity);
        }

        if (health <= 0 && flying)
        {
            if (check)
            {
                check = false;
                score.score += scoreOnDeath;

                int doISpawn = Random.Range(0, 100);
                if (doISpawn > 60)
                {
                    int whatPowerupAmI = Random.Range(0, powerupsToDropAir.Length);
                    Instantiate(powerupsToDropAir[whatPowerupAmI], gameObject.transform.position, Quaternion.identity);
                }
            }
            Destroy(gameObject);
            Destroy(parent);
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
