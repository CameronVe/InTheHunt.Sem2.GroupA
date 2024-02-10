using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;

public class LevelTestingLocations : MonoBehaviour
{
    public GameObject hero;
    public List<Transform> locations;
    public KeyCode keyToChangeLocation = KeyCode.L;
    public int locationIndex = -1;
    
    private void Start()
    {
        locations = GetComponentsInChildren<Transform>().ToList();
        locations.RemoveAt(0);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyToChangeLocation))
        {
            locationIndex++;
            locationIndex = locationIndex % locations.Count;
            Vector3 warpSpot = locations[locationIndex].position;
            hero.transform.position = warpSpot;
            //hero.transform.rotation = locations[locationIndex].rotation;
        }
    }
}
