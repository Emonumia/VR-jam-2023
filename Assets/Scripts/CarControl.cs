using UnityEngine;

public class CarControl : MonoBehaviour
{
    public WheelCollider fLeftWheel;
    public WheelCollider fRightWheel;
    public WheelCollider bLeftWheel;
    public WheelCollider bRightWheel;
    public Transform flWheel1;
    public Transform frWheel2;
    public Transform blWheel3;
    public Transform brWheel4;
    public float maxMotorTorque = 1000f;
    public float maxSteeringAngle = 60f;
    private float acc = 3;
    public GameObject SteeringWheel;

    public bool pedal_of_metal = false;
    private float gasGasGas_i_gotta_step_on_the_gas = 0f;

    private void Start()
    {
        fLeftWheel.motorTorque = 0f;
        fRightWheel.motorTorque = 0f;
        bLeftWheel.motorTorque = 0f;
        bRightWheel.motorTorque = 0f;
        fLeftWheel.steerAngle = 0f;
        fRightWheel.steerAngle = 0f;
    }

    private void Update()
    {
        if (pedal_of_metal)
        {
            // Get input values from the X
            gasGasGas_i_gotta_step_on_the_gas = acc;

        }
        else
            gasGasGas_i_gotta_step_on_the_gas = 0f;
    }

    private void FixedUpdate()
    {
        /* Control the left and right wheels separately
        float leftTorque = leftInput * maxMotorTorque * 0.1f;
        float rightTorque = rightInput * maxMotorTorque * 0.1f;*/

        // Apply torque to the wheels
        fLeftWheel.motorTorque = maxMotorTorque * gasGasGas_i_gotta_step_on_the_gas;
        fRightWheel.motorTorque = maxMotorTorque * gasGasGas_i_gotta_step_on_the_gas;
        //bLeftWheel.motorTorque = maxMotorTorque * gasGasGas_i_gotta_step_on_the_gas;
        //bRightWheel.motorTorque = maxMotorTorque * gasGasGas_i_gotta_step_on_the_gas;


        //Control steering of the wheels
        float SteeringAngle = SteeringWheel.transform.rotation.eulerAngles.y;
        //Debug.Log(fLeftWheel.steerAngle);
        fLeftWheel.steerAngle = SteeringAngle;
        fRightWheel.steerAngle = SteeringAngle;

        if (fLeftWheel.steerAngle != SteeringAngle || fRightWheel.steerAngle != SteeringAngle)
        {
            fLeftWheel.steerAngle = 0f;
            fRightWheel.steerAngle = 0f;
        }


        UpWheels(fLeftWheel, flWheel1);
        UpWheels(fRightWheel, frWheel2);

        UpWheels(bLeftWheel, blWheel3);
        UpWheels(bRightWheel, brWheel4);
    }

    void UpWheels(WheelCollider col, Transform trans)
    {
        Vector3 pos;
        Quaternion rot;
        col.GetWorldPose(out pos, out rot);
        trans.position = pos;
        trans.rotation = rot;
    }
}
