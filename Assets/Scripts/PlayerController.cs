using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Unity.VisualScripting;
using TMPro;



public class PlayerController : MonoBehaviour
{
    
    // Speed of the player 
    public float speed = 0;
    public TextMeshProUGUI countText;
    // The rigidbody of the player 
    private Rigidbody rb;
    private int count;
    public GameObject winTextObject;

    // Movement along the X and Y axes 
    private float movementX;
    private float movementY;
    
    // Start is called before the first frame update
    void Start()
    {
        // Storing the rigidbody on the player
        rb = GetComponent <Rigidbody>();
        count = 0;
        SetCountText();
        winTextObject.SetActive(false);
        
        
    }

    private void FixedUpdate()
    {
        Vector3 movement =  new Vector3 (movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count =  count + 1;
            SetCountText();
        }
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

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 11)
        {
            winTextObject.SetActive(true);
        }

       
    }
    
}
