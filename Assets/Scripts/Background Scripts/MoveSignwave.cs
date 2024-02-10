using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSignwave : MonoBehaviour
{
    float sinCenterY;
    public float amplitude = 2.0f; // Adjust this to control the amplitude of the sine wave
    public float frequency = .5f; // Adjust this to control the frequency of the sine wave

    public bool inverted = false;

    // Start is called before the first frame update
    void Start()
    {
        sinCenterY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Vector2 pos = transform.position;

        float sin = Mathf.Sin(pos.x * frequency) * amplitude;
        if (inverted) 
        {
            sin *= -1;
        }
        pos.y = sinCenterY + sin;

        transform.position = pos;
    }
}
