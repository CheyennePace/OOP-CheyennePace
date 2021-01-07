using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Identifies which player this belongs to
    public int playerNumber = 1;

    // How quickly player moves forward and back
    public float speed = 10f;

    // How quickly player rotates (degrees per second)
    public float rotationSpeed = 180f;

    private Rigidbody2D body;

    // Use this for initialization
    void Start()
    {
        // Retrieve reference to this GameObject's Rigidbody component
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get movement input value
        float movementInput = GetMovementInput();

        // Determine amount to move based on current up direction and speed
        Vector2 movement = transform.up * movementInput * speed * Time.deltaTime;

        // Move our Rigidbody to this position
        body.MovePosition(body.position + movement);

        // Get rotation input value
        float rotationInput = GetRotationInput();

        // Determine number of degrees to turn based on rotation speed
        float degreesToTurn = rotationInput * rotationSpeed * Time.deltaTime;

        // Get Quaternion equivalent of this amount of rotation around the z-axis
        Quaternion rotation = Quaternion.Euler(0f, 0f, degreesToTurn);

        // Rotate our Rigidbody by this amount
        body.MoveRotation(transform.rotation * rotation);
    }

    // Returns input key values of 0, 1 or -1 based on whether Player tries to move forward or back
    float GetMovementInput()
    {
        // Player 1 moves forward and back with W and S; 
        KeyCode positiveKey = KeyCode.W;
        KeyCode negativeKey = KeyCode.S;

        if (Input.GetKey(positiveKey))
        {
            return 1f;
        }
        else if (Input.GetKey(negativeKey))
        {
            return -1f;
        }
        else
        {
            return 0f;
        }
    }

    // Write method body that returns input key values of 0, 1 or -1 based on whether Player tries to rotate right or left
    float GetRotationInput()
    {
        KeyCode positiveKey = KeyCode.D;
        KeyCode negativeKey = KeyCode.A;

        if (Input.GetKey(positiveKey))
        {
            return 1f;
        }
        else if (Input.GetKey(negativeKey))
        {
            return -1f;
        }
        else
        {
            return 0f;
        }
    }

}