using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 25f;
    private float turnSpeed = 45f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   //We get input for moving forward here
        forwardInput = Input.GetAxis("Vertical");
        //We get input for turn here
        horizontalInput = Input.GetAxis("Horizontal");
        //Moves forward
        transform.Translate(Vector3.forward *Time.deltaTime *speed *forwardInput);
        //Rotates/turns the vehicle
        transform.Rotate(Vector3.up* Time.deltaTime * turnSpeed *horizontalInput);
    }
}
