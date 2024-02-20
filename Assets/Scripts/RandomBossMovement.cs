using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RandomBossMovement : MonoBehaviour
{
    float timer = 0;
    float spawnTimer = 0;
    public float allowedTime;
    public float seconds;
    public float spawnWaitTime = 3;

    public float height;
    public float widthRight;
    public float widthLeft;
    public float depth;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTimer > spawnWaitTime)
        {
            if (timer > allowedTime)
            {
                timer = 0;
                Vector3 newVector3Position = new Vector3(Random.Range(widthLeft, widthRight), Random.Range(depth, height), 0);
                transform.DOLocalMove(newVector3Position, seconds);
            }
            else
            {
                timer += Time.deltaTime;
            }
        }
        else if (spawnTimer < spawnWaitTime)
        {
            spawnTimer += Time.deltaTime;
        }

        
    }
}
