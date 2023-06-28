using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mesuringdistance : MonoBehaviour
{
    public Transform point1;
    public Transform point2;

    public GameObject objectToSpawn; // The GameObject to spawn
    public Transform spawnPoint; // The position where the GameObject will be spawned
    public float spawnInterval = 5f; // The time interval between spawns

    private float spawnTimer = 0f; // Timer to track the spawn interval


    void Update()
    {
        spawnTimer += Time.deltaTime;
        float distance = Vector3.Distance(point1.position, point2.position);
        //Debug.Log("Distance between Point 1 and Point 2: " + distance);
        if(100 > distance)
        {
            if (spawnTimer >= spawnInterval)
            {
                // Spawn the GameObject
                SpawnObject();

                // Reset the timer
                spawnTimer = 0f;
            }
        }
    }

    void SpawnObject()
    {
        // Instantiate the GameObject at the spawn point
        Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);
    }
}