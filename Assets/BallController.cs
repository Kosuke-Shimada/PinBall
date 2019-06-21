using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class BallController: MonoBehaviour
{

    private float visiblePosZ = -6.5f;

    private GameObject gameoverText;

    private GameObject ScoreText;

    private int score = 0;

    // Use this for initialization
    void Start()
    {

        this.gameoverText = GameObject.Find("GameOverText");

        this.ScoreText = GameObject.Find("ScoreText");


    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z < this.visiblePosZ)
        {

            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }


     }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "SmallCloudTag")
        {

            score += 10;

        }
        else if (other.gameObject.tag == "LargeStarTag") {

            score += 20;

        }else if (other.gameObject.tag == "SmallStarTag")
        {
            score += 30;
        }else if(other.gameObject.tag == "LargeCloudTag") {

            score += 40;

        }

        string scoreStr = score.ToString();
        this.ScoreText.GetComponent<Text>().text = scoreStr;

    }
}