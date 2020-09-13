using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Compass : MonoBehaviour
{
    public Transform missionCore;
    public RectTransform compassArrow;
    float angle;
    Vector3 coreDirection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coreDirection = missionCore.position - transform.position;
        angle = Vector3.SignedAngle(transform.forward, coreDirection, Vector3.up);
        compassArrow.localEulerAngles = new Vector3(0,0, -angle);
    }
}
