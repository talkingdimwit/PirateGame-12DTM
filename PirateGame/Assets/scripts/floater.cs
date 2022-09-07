using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floater : MonoBehaviour
{
    public Rigidbody Rb;
    public float depthBeforeSubmerge = 1f;
    public float displacementAmount = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 0f)
        {
            float displacementMultiplier = Mathf.Clamp01(-transform.position.y / depthBeforeSubmerge) * displacementAmount;
            Rb.AddForce(new Vector3(0f, Mathf.Abs(Physics.gravity.y) * displacementMultiplier, 0f), ForceMode.Acceleration);
        }

    }
}
