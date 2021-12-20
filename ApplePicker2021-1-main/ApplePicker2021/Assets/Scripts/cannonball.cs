using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonball : MonoBehaviour
{
    public static float bottomy = -20f;
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "basket")
        {
            Destroy(this.gameObject);
        }
    }

}
