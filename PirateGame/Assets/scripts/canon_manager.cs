using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canon_manager : MonoBehaviour
{
    public GameObject cannonBallPrefab;
    public Transform firePoint;
    private Vector3 initialVelocity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            _Fire();
        }
    }

    private void _Fire()
    {
        // instantiate a cannon ball
        GameObject cannonBall = Instantiate(
            cannonBallPrefab,
            firePoint.position,
            Quaternion.identity);

        // apply some force
        Rigidbody rb = cannonBall.GetComponent<Rigidbody>();
        rb.AddForce(initialVelocity);
    }

}
