using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public GameObject ball;
    public int score;
    public Rigidbody rb;
    public LaunchScript launchScript;
    public TextMeshProUGUI scoreText;
    //this script sits on the target and manages collision and new ball spawn
   
    
    private void OnCollisionEnter(Collision collision)
    {
        Vector3 spawnLocation = new Vector3(Random.Range(-7f, 4f), Random.Range(1f, 1.5f), 0);
        if (collision.gameObject.tag == "ball")
        {
            score++;
            scoreText.text = "Score: " + score.ToString();
            Destroy(collision.gameObject);
            GameObject newBall = Instantiate(ball);
            newBall.transform.position = spawnLocation;
            launchScript.rb = newBall.GetComponent<Rigidbody>();
        }
    }



}
