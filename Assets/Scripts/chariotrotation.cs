using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chariotrotation : MonoBehaviour
{
    public GameObject objectToRotate; // The GameObject to rotate
    private bool rotateObject = true; // Flag to control rotation

    void Update()
    {
        if (rotateObject && objectToRotate != null)
        {
            // Rotate the object continuously around the y-axis
            objectToRotate.transform.Rotate(Vector3.forward, Time.deltaTime * 500f); // Adjust the rotation speed as desired
        }
    }

    public void StartRotation()
    {
        rotateObject = true;
    }

    public void StopRotation()
    {
        rotateObject = false;
    }
}



