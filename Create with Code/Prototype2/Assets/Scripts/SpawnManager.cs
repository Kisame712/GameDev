using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float spawnRangeX = 20f;
    private float spawnPosZ = 20f;
    public GameObject[] animalPrefabs;
    private float startDelay = 2.5f;
    private float spawnInterval = 2f;
    // Start is called before the first frame update

    void Start()
    {   //Spawns animals after a delay of startDelay initially, and then after an interval of spwanInterval
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);

    }

    // Update is called once per frame
    void Update()
    {


    }
    //Function to spawn animals from the total animals in the game at random locations
    void SpawnRandomAnimal()
    {
        int arrayIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[arrayIndex], spawnPos, animalPrefabs[arrayIndex].transform.rotation);
    }
}
