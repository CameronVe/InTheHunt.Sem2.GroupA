using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBossMovement : MonoBehaviour
{
    float timer = 0;
    public float allowedTime;
    public float seconds;

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
        if (timer > allowedTime)
        {
            timer = 0;
            Vector3 newVector3Position = new Vector3(Random.Range(widthLeft, widthRight), Random.Range(depth, height), 0);
            DOTween.To(() => transform.localPosition, newPosition => transform.localPosition = newPosition, newVector3Position, seconds);
            //DOTween.Move
        }
        else
        {
            timer += Time.deltaTime;
        }
    }
}
