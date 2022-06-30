using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBoundary = 30f;
    private float lowerBoundary = -10f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   //If the pizza moves past the top boundary, we destroy it
        if (transform.position.z > topBoundary)
        {
            Destroy(gameObject);
        }
        //if the animal moves past the player, the player loses and the animal object is destroyed
        else if (transform.position.z < lowerBoundary)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }

    }
}
