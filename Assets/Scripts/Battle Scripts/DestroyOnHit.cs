using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnHit : MonoBehaviour
{

    bool canDestroy = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   //canDestroy when in view of the camera
        if (transform.position.x < 21)
        {
            canDestroy = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!canDestroy) 
        {
            return;
        }
        Bullet bullet = other.GetComponent<Bullet>();
        if (bullet != null)
        {
            Destroy(gameObject);
            Destroy(bullet.gameObject);
        }
    }
}
