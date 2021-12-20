using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonscript : MonoBehaviour
{
    [Header("Set in Inspector")]
    //Prefab for instantiating apples
    public GameObject cannonballPrefab;
    //rate at which Apples will be instantiated
    public int diffLevel = 0;

    private float _secondsBetweenCannonShoots = 1f;

    private List<GameObject> _cannonball;


    // Start is called before the first frame update
    void Start()
    {
        _cannonball = new List<GameObject>();
        //dropping apples every second
        Invoke("ShootBall", _secondsBetweenCannonShoots);
    }

    void ShootBall()
    {
        _secondsBetweenCannonShoots = Random.Range(1, 2);
        if (_cannonball.Count >= 2)
        {
            if (_cannonball[_cannonball.Count - 2])
            {
                _cannonball[_cannonball.Count - 2].GetComponent<Rigidbody>().isKinematic = false;
                _cannonball[_cannonball.Count - 2].GetComponent<Rigidbody>().useGravity = true;
            }
        }
        GameObject apple = Instantiate<GameObject>(cannonballPrefab);
        _cannonball.Add(apple);
        apple.transform.position = new Vector3(GameObject.FindGameObjectWithTag("cannon1").transform.position.x, GameObject.FindGameObjectWithTag("cannon1").transform.position.y, 12);
        if (diffLevel > 9)
        {
            Invoke("ShootBall", _secondsBetweenCannonShoots - 0.9f);
        }
        else
        {
            Invoke("ShootBall", _secondsBetweenCannonShoots - (diffLevel * 0.1f));
        }    
    }
}
