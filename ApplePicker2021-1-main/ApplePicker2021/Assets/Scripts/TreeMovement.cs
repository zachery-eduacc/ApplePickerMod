using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeMovement : MonoBehaviour
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
        
        GameObject tre = GameObject.FindGameObjectWithTag("tree");
        
        tre.transform.position = new Vector3(GameObject.FindGameObjectWithTag("tree").transform.position.x + Random.Range(-2, 3), GameObject.FindGameObjectWithTag("tree").transform.position.y, GameObject.FindGameObjectWithTag("tree").transform.position.z);
        if (tre.transform.position.x > 20)
        {
            tre.transform.position = new Vector3(0, GameObject.FindGameObjectWithTag("tree").transform.position.y, GameObject.FindGameObjectWithTag("tree").transform.position.z);
        }
        if (tre.transform.position.x < -20)
        {
            tre.transform.position = new Vector3(0, GameObject.FindGameObjectWithTag("tree").transform.position.y, GameObject.FindGameObjectWithTag("tree").transform.position.z);
        }
        
    }
}
