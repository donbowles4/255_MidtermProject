using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LaunchScript : MonoBehaviour
{
    public GameObject ball;
    public Slider powerSlider;
    public Slider angleSlider;
    public Rigidbody rb;
    float launchForce;
    float launchAngle;
    
    public void Start()
    {
       Vector3 spawnLocation = new Vector3(Random.Range(-7f, 4f), Random.Range(1f, 1.5f), 0);
       GameObject newBall = Instantiate(ball);
       newBall.transform.position = spawnLocation;
       rb = newBall.GetComponent<Rigidbody>();
    }
    public void onClickLaunch()
    {
        //LAUNCHING
        launchForce = powerSlider.value;
        launchAngle = angleSlider.value;

        float angleInRadians = Mathf.Deg2Rad * launchAngle;
        Vector3 forceDirection = new Vector3(Mathf.Cos(angleInRadians), Mathf.Sin(angleInRadians), 0);

        rb.AddForce(forceDirection * launchForce, ForceMode.Impulse);
    }
    

}