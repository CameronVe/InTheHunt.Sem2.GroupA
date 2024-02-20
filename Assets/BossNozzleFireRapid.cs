using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossNozzleFireRapid : MonoBehaviour
{
    [SerializeField] Matthew.Bullet bullet;
    [SerializeField] float bulletSpawnTime = 0.8f;
    float timer;


    // Update is called once per frame
    void Update()
    {
        if (timer > bulletSpawnTime)
        {
            timer = 0;
            if (bulletSpawnTime > 0.2)
            {
                bulletSpawnTime -= 0.025f;
            }
            Instantiate(bullet, gameObject.transform.position, Quaternion.identity);
        }
        else
        {
            timer += Time.deltaTime;
        }
    }
}
