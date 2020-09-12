using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Compass : MonoBehaviour
{
    public Transform missionCore;
    public RectTransform compassArrow;
    public Quaternion coreRotation;
    Vector3 coreDirection;
    Vector3 compassdirection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coreDirection = missionCore.position - transform.position;
        
        coreRotation = Quaternion.LookRotation(coreDirection);
        coreRotation.x = 0;
        coreRotation.z = -coreRotation.y;
        coreRotation.y = 0;
        //coreRotation.x= new Vector3(0,0,missionCore.localEulerAngles.y );
        compassArrow.localRotation = coreRotation;
    }
}
