using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int numberOfEnemiesInWave = 3;
    private int currentWave = 1;

    void Start()
    {
        SpawnWave();
        Debug.Log("Wave #" + currentWave);
    }

    void SpawnWave()
    {
        for (int i = 0; i < numberOfEnemiesInWave; i++)
        {
            // Set Location of Enemies
            Vector3 spawnPosition = new Vector3((i*4f)+-4f, 1f, 28f);
            Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
        }
    }
    void Update()
    {
        // Check if all enemies from the current wave have been destroyed
        if (GameObject.FindGameObjectsWithTag("Enemies").Length == 0)
        {
            // Spawning next wave if enemies are destroyed
            currentWave++;
            SpawnWave();
            Debug.Log("Wave #" + currentWave);
        }
    }
}
