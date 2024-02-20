using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawn : MonoBehaviour
{
    [SerializeField] Transform camera;
    [SerializeField] GameObject boss;
    [SerializeField] float animationTime = 5;
    float timer = 0;

    // Update is called once per frame
    void Update()
    {
        if (camera.position.x == 1599)
        {
            boss.SetActive(true);
            if (timer < animationTime)
            {
                boss.transform.DOLocalMoveX(0f, animationTime);
                timer += Time.deltaTime;
            }
        }
    }
}
