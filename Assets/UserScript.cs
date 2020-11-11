using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserScript : MonoBehaviour
{
    int frameCount;
    public Vector3 velocity = new Vector3(0, 0, 0);
    
    

    private int c; 

    // Start is called before the first frame update
    void Start()
    {
      
    }

    public float quickness = 1f;
    // Update is called once per frame
    void Update()
    {
        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        Vector3 direction = input.normalized;
        velocity += quickness * direction;
        Vector3 moveAmount = velocity * Time.deltaTime;

        transform.position += moveAmount;
    }
}
