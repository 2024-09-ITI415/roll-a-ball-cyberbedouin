using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Unity.VisualScripting;



public class PlayerController : MonoBehaviour
{
    
    // Speed of the player 
    public float speed = 0;
    // The rigidbody of the player 
    private Rigidbody rb;

    // Movement along the X and Y axes 
    private float movementX;
    private float movementY;
    
    // Start is called before the first frame update
    void Start()
    {
        // Storing the rigidbody on the player
        rb = GetComponent <Rigidbody>();
        
    }

    private void FixedUpdate()
    {
        Vector3 movement =  new Vector3 (movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);
    }
    // Movement function
    void OnMove(InputValue movementValue)
    {
        // Converts the input into Vector 2 for movement 
        Vector2 movementVector = movementValue.Get<Vector2>();
        // Stores the movement components
        movementX = movementVector.x;
        movementY = movementVector.y;


    }

    
}
