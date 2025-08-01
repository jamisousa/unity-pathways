using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBehavior : MonoBehaviour
{

    public GameObject enemyPrefab;
    float spawnRange = 9;
    public int enemyCount;
    public int waveNumber = 1;


    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWave(waveNumber);
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<EnemyBehavior>().Length;
        Debug.Log("Enemy wave is" + waveNumber + " and enemy count is " + enemyCount);

        if (enemyCount == 0)
        {
            waveNumber++;
            SpawnEnemyWave(waveNumber);
        }
    }


    private Vector3 GenerateSpawnPosition()
    {
        // Generate a random position within the spawn range
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        //Instantiate(enemyPrefab, randomPos, enemyPrefab.transform.rotation);
        return randomPos;
    }

    void SpawnEnemyWave(int enemiesToSpawn)
    {
        // Spawn a wave of enemies
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }
    }
}
