using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using Unity.XR.CoreUtils;

public class Movement : MonoBehaviour
{
    [SerializeField] private XRNode inputSource;
    [SerializeField] private GameObject VRCam;
    [SerializeField] private LayerMask groundLayer;
    private Vector2 inputAxis;
    private XROrigin rig;
    private CharacterController characterController;
    [SerializeField] private float moveSpeed, gravity, additionalHeight;
    private float fallSpeed;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        rig = GetComponent<XROrigin>();
        VRCam.transform.position = new Vector3(transform.position.x, VRCam.transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        InputDevice device = InputDevices.GetDeviceAtXRNode(inputSource);
        device.TryGetFeatureValue(CommonUsages.primary2DAxis, out inputAxis);
    }

    private void FixedUpdate()
    {
        ColliderFollow();

        Quaternion headYaw = Quaternion.Euler(0, rig.Camera.transform.eulerAngles.y, 0);
        Vector3 direction = headYaw * new Vector3(inputAxis.x, 0, inputAxis.y);

        characterController.Move(direction * Time.fixedDeltaTime * moveSpeed);

        if (GroundCheck())
        {
            fallSpeed = 0;
        }
        else
        {
            fallSpeed += gravity * Time.fixedDeltaTime;
        }


        characterController.Move(Vector3.up * fallSpeed * Time.fixedDeltaTime);
    }

    private void ColliderFollow()
    {
        characterController.height = rig.CameraInOriginSpaceHeight + additionalHeight;
        Vector3 capsuleCenter = transform.InverseTransformPoint(rig.Camera.transform.position);
        characterController.center = new Vector3(capsuleCenter.x, characterController.height/2 + characterController.skinWidth, capsuleCenter.z);
    }

    private bool GroundCheck()
    {
        Vector3 rayStart = transform.TransformPoint(characterController.center);
        float rayLength = characterController.center.y + 0.01f;
        bool hasHit = Physics.SphereCast(rayStart, characterController.radius, Vector3.down, out RaycastHit hit, rayLength, groundLayer);
        return hasHit;
    }
}
