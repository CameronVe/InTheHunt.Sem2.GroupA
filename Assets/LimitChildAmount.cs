using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitChildAmount : MonoBehaviour
{
    [SerializeField] int childCountLimit;

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.childCount > childCountLimit)
        {
            Destroy(gameObject.transform.GetChild(0).gameObject);
        }
    }
}
