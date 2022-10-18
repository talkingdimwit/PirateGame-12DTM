using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class cannon_Controller : MonoBehaviour
{
    public Transform ballPos;
    public Rigidbody Ball;
    public GameObject effect;
    float forceAmount = 13000;


    void Update()
    {
        Rigidbody ballRigid;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ballRigid = Instantiate(Ball, ballPos.position, ballPos.rotation) as Rigidbody;
            ballRigid.AddForce(ballPos.forward * forceAmount);
            ballRigid.AddForce(ballPos.right * 10 * Time.deltaTime);
        }
    }
}
