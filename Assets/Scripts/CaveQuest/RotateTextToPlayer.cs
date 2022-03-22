using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTextToPlayer : MonoBehaviour
{
    private void Update()
    {
        this.transform.LookAt(Camera.main.transform);
        this.transform.localEulerAngles = new Vector3(0, 180, 0);
    }
}
