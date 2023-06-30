using UnityEngine;
//some of the program has been artificially generated (gpt)

public class OpenDoors : MonoBehaviour
{
    public GameObject carDoor;
    //public Quaternion oP = Quaternion.Euler(0f, 90f, 0f);
    //public Quaternion cL = Quaternion.Euler(0f, 0f, 0f);
    public float oP = 270f;
    public float cL = 0f;
    private bool oPdoor = false;

    void Update()
    {
        //Debug.Log(oP);
        //Debug.Log(carDoor.transform.rotation.eulerAngles.z);
        if (oPdoor && Mathf.Round(carDoor.transform.rotation.eulerAngles.z)!= oP)
        {
            // Rotate the object continuously around the z-axis
            carDoor.transform.Rotate(Vector3.forward, -Time.deltaTime * 50f); // Adjust the rotation speed as desired
        }
        else if (!oPdoor && Mathf.Abs(Mathf.Round(carDoor.transform.rotation.eulerAngles.z)) != cL)
            carDoor.transform.Rotate(Vector3.forward, Time.deltaTime * 50f);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Player detected
            //Debug.Log("Player detected!");
            // Add your custom logic here, such as starting the car or triggering an event
            oPdoor = true;
            //carDoor.transform.localRotation = oP;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Player exited
            //Debug.Log("Player exited!");
            // Add your custom logic here, such as stopping the car or triggering an event
            oPdoor = false;
            //carDoor.transform.localRotation = cL;

        }
    }
}

