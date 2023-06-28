using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoyObject : MonoBehaviour
{
    public GameObject[] objectsToDestroy;
    public float delay = 3f; // Delay in seconds

    void Start()
    {
        foreach (GameObject obj in objectsToDestroy)
        {
            Destroy(obj, delay);
        }
    }
}


