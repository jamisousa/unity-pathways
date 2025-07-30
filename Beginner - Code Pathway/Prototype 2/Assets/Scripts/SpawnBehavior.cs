using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBehavior : MonoBehaviour
{


    public GameObject[] objectsToSpawn; // Array of objects to spawn
    private float spawnRangeX = 20;
    private float spawnRangeZ = 40;
    private float startDelay = 2.0f; // Delay before starting the spawn
    private float spawnInterval = 1f; // Interval between spawns

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval); // Call SpawnRandomAnimal method repeatedly with a delay and interval

    }

    // Update is called once per frame
    void Update()
    {
        ////Spawn a random animal 

        //if (Input.GetKeyDown(KeyCode.S))
        //{
        //}


    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, objectsToSpawn.Length); // Randomly select an index from the array

     
            // Generate a random position within the specified range
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, Random.Range(-spawnRangeZ, spawnRangeZ));

            Instantiate(objectsToSpawn[animalIndex], spawnPosition, objectsToSpawn[animalIndex].transform.rotation);
        
    }
}
