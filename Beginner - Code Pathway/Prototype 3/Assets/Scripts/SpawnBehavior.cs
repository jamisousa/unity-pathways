using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBehavior : MonoBehaviour
{

    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2f;
    private float repeatRate = 2f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstable", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstable()
    {
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);

    }
}
