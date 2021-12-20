using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class health : MonoBehaviour
{
    public int maxhealth = 3;
    public int currenthealth;



    void Start()
    {
        currenthealth = maxhealth;


    }

   

    void TakeDamage(int amount)
    {
        
        currenthealth -= amount;

        if(currenthealth <= 0)
        {
            SceneManager.LoadScene(0);
        }

    }
     private void OnCollisionEnter(Collision col)
        {
            if(col.gameObject.tag != "Apple")
            {
                TakeDamage(1);
            }
        }
}
