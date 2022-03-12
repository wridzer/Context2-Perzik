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
    private Vector2 inputAxis;
    private XROrigin rig;
    private CharacterController characterController;
    [SerializeField] private float moveSpeed = 1;
    [SerializeField] private float gravity = 1;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        rig = GetComponent<XROrigin>();
    }

    // Update is called once per frame
    void Update()
    {
        InputDevice device = InputDevices.GetDeviceAtXRNode(inputSource);
        device.TryGetFeatureValue(CommonUsages.primary2DAxis, out inputAxis);
        //characterController.center = new Vector3(VRCam.transform.position.x - transform.position.x, 1f, VRCam.transform.position.y - transform.position.y);

    }

    private void FixedUpdate()
    {
        Quaternion headYaw = Quaternion.Euler(0, rig.Camera.transform.eulerAngles.y, 0);

        Vector3 direction = headYaw * new Vector3(inputAxis.x, 0, inputAxis.y);
        Vector3 gravityV = new Vector3(0, -gravity, 0);
        characterController.Move((direction + gravityV) * Time.fixedDeltaTime * moveSpeed);
    }
}
