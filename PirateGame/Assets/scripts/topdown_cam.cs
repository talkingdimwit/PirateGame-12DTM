using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topdown_cam : MonoBehaviour
{
    // camera will follow this object
    public Transform Target;
    //camera transform
    public Transform camTransform;
    // offset between camera and target
    public Vector3 Offset;
    // change smoothness
    public float SmoothTime = 0.3f;

    // makes sure the camera starts with no movement
    private Vector3 velocity = Vector3.zero;

    private void Start()
    {
        Offset = camTransform.position - Target.position;
    }

    private void LateUpdate()
    {
        // update position
        Vector3 targetPosition = Target.position + Offset;
        camTransform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, SmoothTime);

        // update rotation
        transform.LookAt(Target);
    }
}