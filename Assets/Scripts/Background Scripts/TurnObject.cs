using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class TurnObject : MonoBehaviour
{
    //[SerializeField] float secondsToCompleteAnimation = 0.1f;
    [SerializeField] bool rotateX;
    [SerializeField] bool rotateY;
    [SerializeField] bool rotateZ;

    float x;
    float y;
    float z;

    private void Start()
    {
        x = gameObject.transform.localRotation.x;
        y = gameObject.transform.localRotation.y;
        z = gameObject.transform.localRotation.z;
    }

    private void Update()
    {
        if (rotateX == true)
        {
            //transform.DOLocalRotate(new Vector3(360f, y, z), secondsToCompleteAnimation);
            gameObject.transform.localRotation = Quaternion.Euler(Turn.spin, y, z);
        }

        if (rotateY == true)
        {
            //transform.DOLocalRotate(new Vector3(x, 360f, y), secondsToCompleteAnimation);
            gameObject.transform.localRotation = Quaternion.Euler(x, Turn.spin, z);
        }

        if (rotateZ == true)
        {
            //transform.DOLocalRotate(new Vector3(x, y, 360f), secondsToCompleteAnimation);
            gameObject.transform.localRotation = Quaternion.Euler(x, y, Turn.spin);
        }
    }
}
