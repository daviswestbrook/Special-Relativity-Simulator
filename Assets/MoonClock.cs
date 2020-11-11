using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonClock : MonoBehaviour
{
    float speed = .5f;
    public float distanceFromPlanet = 3;
    float theta = 0;
    public GameObject User;
    private UserScript userScript;
    Vector3 userVelocity;
    Vector3 clockVelocity;
    public int c = 10;
    Vector3 relativeVelocity;
    float relativeSpeed;
    float gamma;
    
    void Start()
    {
        userScript = User.GetComponent<UserScript>();

        clockVelocity = new Vector3(0, 0, 0);
    }



    void Update()
    { 
        userVelocity = userScript.velocity;
        relativeVelocity = userVelocity - clockVelocity;
        relativeSpeed = relativeVelocity.magnitude;
        gamma = 1 / Mathf.Sqrt(1 - Mathf.Pow(relativeSpeed, 2)/Mathf.Pow(c, 2));
        print(gamma);
        theta += (speed * 2 * Mathf.PI * Time.deltaTime)/gamma;
        transform.localPosition = new Vector3(distanceFromPlanet * Mathf.Cos(theta), 0, distanceFromPlanet * Mathf.Sin(theta));
    }

    public int C
    {
        get
        {
            return this.c;
        }
    }
}
