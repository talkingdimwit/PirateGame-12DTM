using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boat_controller : MonoBehaviour
{
    float acceleration = 0.0f;
    // Use this for initialization
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
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
            //Increase forward acceleration
            if (acceleration < 10.0f)
            {
                acceleration += 0.1f;
            }
        }
        //If the player presses S
        if (Input.GetKey(KeyCode.S))
        {
            //Accelerate in the reverse direction.
            if (acceleration > -10.0f)
            {
                acceleration -= 0.1f;
            }
        }
        //If the player is not pressing forward or backward.
        if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S))
        {
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
            //Rotates the player to the left
            transform.Rotate(transform.up, 100.0f * Time.deltaTime, Space.World);
        }
        //If the player presses A
        if (Input.GetKey(KeyCode.A))
        {
            //Rotates the player to the right
            transform.Rotate(transform.up, -100.0f * Time.deltaTime, Space.World);
        }
    }
}
