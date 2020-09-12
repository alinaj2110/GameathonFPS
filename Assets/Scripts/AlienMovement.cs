using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienMovement : MonoBehaviour
{
    public float speed=5.0f;
    public float alienAttackRange=20.0f;
    public string playername;
    private GameObject player;
    bool playerDetection = false;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find(playername);
    }

    // Update is called once per frame
    void Update()
    {
        //alien moves when player comes near it
        if (Vector3.Distance(transform.position, player.transform.position) < alienAttackRange)
            playerDetection = true;
        
        if(playerDetection)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, step);
        }
    }

  
}
