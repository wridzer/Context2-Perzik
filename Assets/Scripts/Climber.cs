using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class Climber : MonoBehaviour
{
    private CharacterController characterController;
    public static XRController climbingHand;
    private DeviceBasedContinuousMoveProvider continuousMovement;
    private Movement movement;

    private XRController previousHand;
    private Vector3 previousPos;
    private Vector3 currentVelocity;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        continuousMovement = GetComponent<DeviceBasedContinuousMoveProvider>();
        movement = GetComponent<Movement>();
        Debug.Log(previousPos);
    }

    void FixedUpdate()
    {
        if (climbingHand)
        {
            continuousMovement.enabled = false;
            movement.enabled = false;
            Climb();
        }
        else
        {
            continuousMovement.enabled = true;
            movement.enabled = true;
        }
    }

    private void Climb()
    {
        InputDevices.GetDeviceAtXRNode(climbingHand.controllerNode).TryGetFeatureValue(CommonUsages.deviceVelocity, out Vector3 velocity);

        characterController.Move(transform.rotation * -velocity * Time.deltaTime);
    }
}