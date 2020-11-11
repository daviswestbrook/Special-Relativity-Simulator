using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserClock : MonoBehaviour
{
    
    public float speed = 0.5f;
    public float distanceFromPlanet = 3;
    float theta = 0;


    // Update is called once per frame


    void Update()
    {

        theta += speed * 2 * Mathf.PI * Time.deltaTime;
        transform.localPosition = new Vector3(distanceFromPlanet*Mathf.Cos(theta), 0, distanceFromPlanet*Mathf.Sin(theta));
    }
}
