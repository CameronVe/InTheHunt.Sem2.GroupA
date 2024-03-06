using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class EnemyFire : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        
        Vector3 vector3 = gameObject.transform.right ;
        Instantiate(GameObject.CreatePrimitive(PrimitiveType.Sphere), vector3, Quaternion.identity);
    }
}
