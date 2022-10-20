using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boat_controller : MonoBehaviour
{
    public float acceleration = 0.0f;
    public Rigidbody rb;
    // Use this for initialization
    void Start()
    {

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        MoveCharacter();
        RotateCharacter();
    }
    //Gathers input to move the character
    void MoveCharacter()
    {
        //If the player presses W
        if (Input.GetKey(KeyCode.W))
        {
            rb.constraints = ~RigidbodyConstraints.FreezePositionX;
            rb.constraints = ~RigidbodyConstraints.FreezePositionZ;
            rb.constraints = ~RigidbodyConstraints.FreezeRotationY;
            //Increase forward acceleration
            if (acceleration < 10.0f)
            {
                acceleration += 0.1f;
            }
        }
        //If the player presses S
        if (Input.GetKey(KeyCode.S))
        {
            rb.constraints = ~RigidbodyConstraints.FreezePositionX;
            rb.constraints = ~RigidbodyConstraints.FreezePositionZ;
            rb.constraints = ~RigidbodyConstraints.FreezeRotationY;
            //Accelerate in the reverse direction.
            if (acceleration > -10.0f)
            {
                acceleration -= 0.1f;
            }
        }
        //If the player is not pressing forward or backward.
        if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S))
        {
            rb.constraints = RigidbodyConstraints.FreezePositionY;
            //Decrease acceleration.
            if (acceleration > 0.0f)
            {
                acceleration -= 0.1f;
            }
            if (acceleration < 0.0f)
            {
                acceleration += 0.1f;
            }
        }

        //If the player is not supposed to be moving, explicitly tell him so.
        if (acceleration > -0.05f && acceleration < 0.05f)
        {
            acceleration = 0.0f;
            rb.constraints = RigidbodyConstraints.FreezeAll;
        }
        //Move the character in its own forward direction while taking acceleration and time into account.
        transform.Translate(transform.forward * acceleration * Time.deltaTime, Space.World);
    }
    //Gathers input to rotate the character.
    void RotateCharacter()
    {
        //If the player presses D
        if (Input.GetKey(KeyCode.D))
        {
            rb.constraints = ~RigidbodyConstraints.FreezePositionX;
            rb.constraints = ~RigidbodyConstraints.FreezePositionZ;
            rb.constraints = ~RigidbodyConstraints.FreezeRotationY;
            //Rotates the player to the left
            transform.Rotate(transform.up, 100.0f * Time.deltaTime, Space.World);
        }
        //If the player presses A
        if (Input.GetKey(KeyCode.A))
        {
            rb.constraints = ~RigidbodyConstraints.FreezePositionX;
            rb.constraints = ~RigidbodyConstraints.FreezePositionZ;
            rb.constraints = ~RigidbodyConstraints.FreezeRotationY;
            //Rotates the player to the right
            transform.Rotate(transform.up, -100.0f * Time.deltaTime, Space.World);
        }
    }
}
