using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement3D : MonoBehaviour
{
    float horizontalInput;
    float verticalInput;
    public float movementSpeed;
    public float runSpeed;
    bool holdingSprintButton = false;
    bool isSprinting = false;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update(){
        GetMovementInput();
    }

    void FixedUpdate()
    {
        HandleSprinting();
        MovePlayer();
    }

    void MovePlayer(){
        if (isSprinting){
            rb.velocity = new Vector3(horizontalInput * runSpeed, 0, verticalInput * runSpeed);
        }
        else{
            rb.velocity = new Vector3(horizontalInput * movementSpeed, 0, verticalInput * movementSpeed);
        }
    }
    void GetMovementInput(){
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }
    void HandleSprinting(){
        holdingSprintButton = Input.GetKey(KeyCode.LeftShift);
        
        isSprinting = holdingSprintButton;
    }
}
