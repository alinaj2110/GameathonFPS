using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienDestroy : MonoBehaviour
{
    public int requiredDamage;
    public float selfDestructionSeconds;
    int hitcount;
    //public GameObject playerbullet;
    // Start is called before the first frame update
    void Start()
    {
        hitcount = 0;
        //Destroy(gameObject, selfDestructionSeconds);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        ++hitcount;
        if(hitcount==requiredDamage)
            Destroy(gameObject);
        //Destroy(other.gameObject);
    }
}
