using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    private float randomTime;
    private float randomRed;
    private float randomGreen;
    private float randomBlue;
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
        transform.localScale = Vector3.one * 1.5f;
        
      
        randomTime = Random.Range(5.0f, 20f);
   
    }
    
    void Update()
    {
        randomRed = Random.Range(0.0f, 1f);
        randomBlue = Random.Range(0.0f, 1f);
        randomGreen = Random.Range(0.0f, 1f);
        Material material = Renderer.material;
        material.color = new Color(randomRed, randomBlue, randomGreen);
        transform.Rotate(20.0f * Time.deltaTime, 0.0f, 0.0f);
        Invoke("RotateDelay", randomTime);
    }
    void RotateDelay ()
    {
        transform.Rotate(0f, 10f * Time.deltaTime, 0f);

    }
    
}
