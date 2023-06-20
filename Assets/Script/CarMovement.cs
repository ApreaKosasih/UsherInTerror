using System;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
   
    private const string HORIZONTAL = "Horizontal";
    private const string VERTICAL = "Vertical";


    private float verticalInput;
    private float horizontalInput;
    private float currentSteerAngle;
    private float currentBreakForce;
    private bool isBreaking;

    [SerializeField] private float motorForce;
    [SerializeField] private float breakForce;
    [SerializeField] private float maxSteeringAngle;

    [SerializeField] private WheelCollider Wheel_FL_Collider;
    [SerializeField] private WheelCollider Wheel_FR_Collider;
    [SerializeField] private WheelCollider Wheel_RL_Collider;
    [SerializeField] private WheelCollider Wheel_RR_Collider;

    [SerializeField] private Transform Wheel_FL;
    [SerializeField] private Transform Wheel_FR;
    [SerializeField] private Transform Wheel_RL;
    [SerializeField] private Transform Wheel_RR;

    private void FixedUpdate()
    {
        GetInput();
        HandleMotor();
        HandleSteering();
        UpdateWheel();

    }

    private void GetInput()
    {
        horizontalInput = Input.GetAxis(HORIZONTAL);
        verticalInput = Input.GetAxis(VERTICAL);
        isBreaking = Input.GetKey(KeyCode.Space);
    }

    private void HandleMotor()
    {
        {
            Wheel_FL_Collider.motorTorque = verticalInput * motorForce;
            Wheel_FR_Collider.motorTorque = verticalInput * motorForce;
            currentBreakForce = isBreaking ? breakForce : 0f;
            ApplyBreaking();
        }
    }



    private void ApplyBreaking()
    {
        Wheel_FL_Collider.brakeTorque = currentBreakForce;
        Wheel_FR_Collider.brakeTorque = currentBreakForce;
        Wheel_RR_Collider.brakeTorque = currentBreakForce;
        Wheel_RL_Collider.brakeTorque = currentBreakForce;
    }

    private void HandleSteering()
    {
        currentSteerAngle = maxSteeringAngle * horizontalInput;
        Wheel_FL_Collider.steerAngle = currentSteerAngle;
        Wheel_FR_Collider.steerAngle = currentSteerAngle;
    }

    private void UpdateWheel()
    {
        UpdateSingleWheel(Wheel_FL_Collider, Wheel_FL);
        UpdateSingleWheel(Wheel_FR_Collider, Wheel_FR);
        UpdateSingleWheel(Wheel_RL_Collider, Wheel_RL);
        UpdateSingleWheel(Wheel_RR_Collider, Wheel_RR);
    }

    private void UpdateSingleWheel(WheelCollider wheel_Collider, Transform wheel)
    {
        Vector3 pos;
        Quaternion rot;
        wheel_Collider.GetWorldPose(out pos, out rot);
        wheel.rotation = rot;
        wheel.position = pos;

    }
}
