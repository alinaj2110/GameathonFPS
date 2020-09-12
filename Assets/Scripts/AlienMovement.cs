using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienMovement : MonoBehaviour
{
    public float speed=5.0f;
    public float alienAttackRange=20.0f;
    public GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, player.transform.position) < alienAttackRange)
        {
            //alien moves when player comes near it
            //Ray ray = new Ray(transform.position, player.transform.position);
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, step);
        }
    }
}
