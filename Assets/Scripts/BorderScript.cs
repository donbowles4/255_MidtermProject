using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderScript : MonoBehaviour
{
    public GameObject ball;
    public Rigidbody rb;
    public LaunchScript launchScript;
    
    private void OnCollisionEnter(Collision collision)
    {
        Vector3 spawnLocation = new Vector3(Random.Range(-7f, 4f), Random.Range(1f, 1.5f), 0);
        if (collision.gameObject.tag == "ball")
        {
            Destroy(collision.gameObject);
            GameObject newBall = Instantiate(ball);
            newBall.transform.position = spawnLocation;
            launchScript.rb = newBall.GetComponent<Rigidbody>();
        }
    }
}
