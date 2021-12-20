using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonmovement : MonoBehaviour
{


    int direction = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {


        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);

        if (this.transform.position.y >= 0){
            direction = 20;
        }
        if (this.transform.position.y <= -15){
            direction = 10;
        }
        if (direction == 10)
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1, this.transform.position.z);
            
        }
        if (direction == 20)
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - 1, this.transform.position.z);

        }

    }
}
