using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienRandomSpawner : MonoBehaviour
{
    public GameObject core;
    public GameObject[] alienPrefabs;
    public float zone_radius_min;
    public float zone_radius_max;
    private float zone_range;
    public float timedelay = 2.0f;
    public float repRate;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = core.transform.position;
        zone_range = zone_radius_max - zone_radius_min;
        InvokeRepeating("AlienSpawn",timedelay, repRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //spawn function
    void AlienSpawn()
    {
        int index = Random.Range(0, alienPrefabs.Length);
        //Vector2 unitspawnPos = Random.insideUnitCircle.normalized;
        Vector3 spawnPos = randZonePoint(zone_radius_min); //new Vector3(unitspawnPos.x * zone_radius_min, 0.5f, unitspawnPos.y * zone_radius_min); - new Vector3(unitspawnPos.x * zone_radius_min, 0.0f, unitspawnPos.y * zone_radius_min);
        //Debug.Log(spawnPos.ToString("F4"));
        Instantiate(alienPrefabs[index], spawnPos, alienPrefabs[index].transform.rotation);
    }

    Vector3 randZonePoint(float minRadius)
    { 
        Vector3 vect= new Vector3(Random.Range(-zone_range, zone_range),0.5f, Random.Range(-zone_range, zone_range));
        if (vect.x < 0)
            vect.x = vect.x - minRadius;
        else
            vect.x = vect.x + minRadius;
        
        if (vect.z < 0)
            vect.z = vect.z - minRadius;
        else
            vect.z = vect.z + minRadius;

        return vect;
    }

    
}
