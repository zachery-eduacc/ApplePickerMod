using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Basket : MonoBehaviour
{
    [Header("Set Dynamically")]
    public Text scoreGT;
    // Start is called before the first frame update
    void Start()
    {
        // find a reference to the TextScoreCounter game object
        GameObject scoreGO = GameObject.Find("TextScoreCounter");
        scoreGT = scoreGO.GetComponent<Text>();
        scoreGT.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 mousePos2d = Input.mousePosition;
        mousePos2d.z = -Camera.main.transform.position.z;
        Vector3 mousePos3d = Camera.main.ScreenToWorldPoint(mousePos2d);
        Vector3 pos = this.transform.position;
        pos.x = mousePos3d.x;
        pos.y = mousePos3d.y;
        this.transform.position = pos;
        GameObject bask = GameObject.FindGameObjectWithTag("basket");
        bask.transform.position = new Vector3(GameObject.FindGameObjectWithTag("basket").transform.position.x, GameObject.FindGameObjectWithTag("basket").transform.position.y, GameObject.FindGameObjectWithTag("basket").transform.position.z);
        if (bask.transform.position.y > 0)
        {
            bask.transform.position = new Vector3(GameObject.FindGameObjectWithTag("basket").transform.position.x, 0, GameObject.FindGameObjectWithTag("basket").transform.position.z);
        }
        if (bask.transform.position.y < -15)
        {
            bask.transform.position = new Vector3(GameObject.FindGameObjectWithTag("basket").transform.position.x, -15, GameObject.FindGameObjectWithTag("basket").transform.position.z);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject collidedWith = collision.gameObject;
        if (collidedWith.tag == "Apple")
        {
            Destroy(collidedWith);
            int score = int.Parse(scoreGT.text);
            score += 100;
            scoreGT.text = score.ToString();
            if (score > HighScore.score)
            {
                HighScore.score = score;
            }
        }
    }
}
