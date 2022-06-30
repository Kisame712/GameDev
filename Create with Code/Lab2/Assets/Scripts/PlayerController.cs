using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10f;
    private float zbound_low = -6f;
    private float zbound_high = 11.7f;
    private Rigidbody playerRb;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        ConstrainPlayer();

    }
    //Moves the player
    void MovePlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        playerRb.AddForce(Vector3.forward * speed * verticalInput);
        playerRb.AddForce(Vector3.right * speed * horizontalInput);
    }

    //Prevents player from moving out of bounds
    void ConstrainPlayer()
    {
        if (transform.position.z > zbound_high)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zbound_high);
        }
        if (transform.position.z < zbound_low)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zbound_low);
        }


    }

}
