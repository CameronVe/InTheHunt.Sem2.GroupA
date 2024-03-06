using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ExplosionAnimation : MonoBehaviour
{
    float scale = 0.2f;
    float add = 0.5f;

    GameObject audio;
    private void Awake()
    {
        audio = GameObject.FindWithTag("Audio");
        audio.GetComponent<AudioSource>().Play();
    }
    // Update is called once per frame
    void Update()
    {
        scale += add;
        if (scale < 20)
        {
            transform.localScale = new Vector3(scale, scale, scale);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
