using UnityEngine;
//some of the program has been artificially generated (gpt)

public class OpenDoors : MonoBehaviour
{
    public GameObject carDoor;
    public Quaternion oP = Quaternion.Euler(0f, 90f, 0f);
    public Quaternion cL = Quaternion.Euler(0f, 0f, 0f);
    //private bool oPdoor;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Player detected
            Debug.Log("Player detected!");
            // Add your custom logic here, such as starting the car or triggering an event

            carDoor.transform.localRotation = oP;


        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Player exited
            Debug.Log("Player exited!");
            // Add your custom logic here, such as stopping the car or triggering an event

            carDoor.transform.localRotation = cL;

        }
    }
}

