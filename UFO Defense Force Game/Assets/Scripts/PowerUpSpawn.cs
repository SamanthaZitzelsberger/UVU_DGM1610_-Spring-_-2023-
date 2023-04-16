using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawn : MonoBehaviour
{
    public GameObject[] powerUpPrefabs; // Array to store powerup
    private float spawnRangeX = 20f;
    private float spawnPosZ = 20f;

    private float startDelay = 2f;
    private float spawnInterval = 1.5f;


    void Start()
    {
        InvokeRepeating("SpawnRandomPowerUp", startDelay, spawnInterval);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            SpawnRandomPowerUp();
        }
    }
    
    void SpawnRandomPowerUp()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),0,spawnPosZ);
            int powerUpIndex = Random.Range(0,powerUpPrefabs.Length); // Picks a random UFO from the array
            Instantiate(powerUpPrefabs[powerUpIndex],spawnPos, powerUpPrefabs[powerUpIndex].transform.rotation); // Spawns a indexed UFO from the array a random location on the X-axis
        }
   }
}
