using UnityEngine;

public class WheelControl : MonoBehaviour
{
    public WheelCollider leftWheel;
    public WheelCollider rightWheel;
    public float maxTorque = 500f;

    private float leftInput;
    private float rightInput;

    private void Update()
    {
        // Get input values from the levers
        leftInput = Input.GetAxis("LeftLever");
        rightInput = Input.GetAxis("RightLever");
    }

    private void FixedUpdate()
    {
        // Apply torque to the wheels based on lever inputs
        float leftTorque = leftInput * maxTorque;
        float rightTorque = rightInput * maxTorque;

        leftWheel.motorTorque = leftTorque;
        rightWheel.motorTorque = rightTorque;
    }
}
