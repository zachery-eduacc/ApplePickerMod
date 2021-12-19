using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Set in Inspector")]
    //Prefab for instantiating apples
    public GameObject applePrefab;
    //rate at which Apples will be instantiated
    public int diffLevel = 0;

    private float _secondsBetweenAppleDrops = 1f;

    private List<GameObject> _apples;


    // Start is called before the first frame update
    void Start()
    {
        _apples = new List<GameObject>();
        //dropping apples every second
        Invoke("DropApple", _secondsBetweenAppleDrops);
    }

    void DropApple()
    {
        if (_apples.Count >= 2)
        {
            if (_apples[_apples.Count - 2])
            {
                _apples[_apples.Count - 2].GetComponent<Rigidbody>().isKinematic = false;
                _apples[_apples.Count - 2].GetComponent<Rigidbody>().useGravity = true;
            }
        }
        GameObject apple = Instantiate<GameObject>(applePrefab);
        _apples.Add(apple);
        apple.transform.position = new Vector3(GameObject.FindGameObjectWithTag("tree").transform.position.x, GameObject.FindGameObjectWithTag("tree").transform.position.y, 0);
        if (diffLevel > 9)
        {
            Invoke("DropApple", _secondsBetweenAppleDrops - 0.9f);
        }
        else
        {
            Invoke("DropApple", _secondsBetweenAppleDrops - (diffLevel * 0.1f));
        }    
    }
}
