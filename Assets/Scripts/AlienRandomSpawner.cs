using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienRandomSpawner : MonoBehaviour
{
    public GameObject core;
    public GameObject[] alienPrefabs;
    public float spawnX = 20.0f;
    public float spawnZ = 30.0f;
    public float timedelay = 2.0f;
    public float repRate=2.0f;
    // Start is called before the first frame update
    void Start()
    {
        //for(int i=0; i< repRate.Length; i++)
        transform.position = core.transform.position;
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
        Vector3 spawnPos = new Vector3(Random.Range(-spawnX, spawnX), 1, Random.Range(-spawnZ,spawnZ));
        Instantiate(alienPrefabs[index], spawnPos, alienPrefabs[index].transform.rotation);
    }
}
