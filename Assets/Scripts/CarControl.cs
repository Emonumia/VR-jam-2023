using System;
using UnityEngine;

public class CarControl : MonoBehaviour
{
    public WheelCollider leftWheel;
    public WheelCollider rightWheel;
    public float maxMotorTorque = 100f;
    //public float maxSteeringAngle = 0f;
    public GameObject left;
    public GameObject right;

    private float leftInput = 0f;
    private float rightInput = 0f;

    private void Start()
    {
        leftWheel.motorTorque = 0;
        rightWheel.motorTorque = 0;
    }

    private void Update()
    {

        if (Math.Abs(left.transform.rotation.eulerAngles.x -270) > 5 || Math.Abs(right.transform.rotation.eulerAngles.x -270) > 5)
        {
            // Get input values from the levers
            leftInput = left.transform.rotation.eulerAngles.x - 270;
            rightInput = right.transform.rotation.eulerAngles.x - 270;
        }


        if ( leftInput > 0 || rightInput > 0)
        {
            Debug.Log("Vroom");
            Debug.Log(leftInput);
            Debug.Log(rightInput);
        }
    }

    private void FixedUpdate()
    {
        // Control the left and right wheels separately
        float leftTorque = leftInput * maxMotorTorque * 0.1f;
        float rightTorque = rightInput * maxMotorTorque * 0.1f;

        // Apply torque to the wheels
        leftWheel.motorTorque = leftTorque;
        rightWheel.motorTorque = rightTorque;


        /*/ Control steering of the wheels
        float leftSteeringAngle = leftInput * maxSteeringAngle;
        float rightSteeringAngle = rightInput * maxSteeringAngle;

        leftWheel.steerAngle = leftSteeringAngle;
        rightWheel.steerAngle = rightSteeringAngle;*/
    }
}
