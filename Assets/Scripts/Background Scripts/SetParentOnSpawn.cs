using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class SetParentOnSpawn : MonoBehaviour
{
    [SerializeField] string parentTagName;

    Transform parent;
    // Start is called before the first frame update
    void Start()
    {

        parent = GameObject.FindWithTag(parentTagName).transform;
        gameObject.transform.SetParent(parent);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
