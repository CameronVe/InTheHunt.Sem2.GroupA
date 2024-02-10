using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField] GameObject parent;
    public int health = 1;
    [SerializeField] bool isBoss;
    [SerializeField] bool isPlayer;

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
            Destroy(gameObject);
            Destroy(parent);
        }
    }
}
