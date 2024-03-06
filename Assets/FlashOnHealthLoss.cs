using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashOnHealthLoss : MonoBehaviour
{
    [SerializeField] int healthOld;
    [SerializeField] int health;
    [SerializeField] GameObject healthFlash;

    private void Start()
    {
        health = gameObject.GetComponent<Health>().health;
        healthOld = health;
    }

    // Update is called once per frame
    void Update()
    {
        health = gameObject.GetComponent<Health>().health;

        if (health < healthOld)
        {
            healthOld = health;
            StartCoroutine(Flash());
        }
    }

    IEnumerator Flash()
    {
        healthFlash.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        healthFlash.SetActive(false);
        yield return new WaitForSeconds(0.2f);
        healthFlash.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        healthFlash.SetActive(false);

    }
}
