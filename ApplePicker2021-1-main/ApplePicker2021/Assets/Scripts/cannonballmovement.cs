using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonballmovement : MonoBehaviour
{
   
    
    int limitleft = -30;
    int limitright = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        GameObject tre = GameObject.FindGameObjectWithTag("cannonball");
        
        tre.transform.position = new Vector3((GameObject.FindGameObjectWithTag("cannonball").transform.position.x - 2), GameObject.FindGameObjectWithTag("cannonball").transform.position.y, GameObject.FindGameObjectWithTag("cannonball").transform.position.z);
        
        
    }
}
