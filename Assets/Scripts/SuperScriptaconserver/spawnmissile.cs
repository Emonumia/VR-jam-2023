using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnmissile : MonoBehaviour
{
    public GameObject objectToSpawn; // The GameObject to spawn
    public Transform spawnPoint; // The position where the GameObject will be spawned
    public float spawnInterval = 5f; // The time interval between spawns

    private float spawnTimer = 0f; // Timer to track the spawn interval

    void Update()
    {
        // Increment the timer
        spawnTimer += Time.deltaTime;

        // Check if the spawn interval has elapsed
        if (spawnTimer >= spawnInterval)
        {
            // Spawn the GameObject
            SpawnObject();

            // Reset the timer
            spawnTimer = 0f;
        }
    }

    void SpawnObject()
    {
        // Instantiate the GameObject at the spawn point
        Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);
    }
}
