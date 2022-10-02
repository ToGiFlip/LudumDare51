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
    public bool isSprinting = false;
    public float stamCurrent = 100f;
    public float stamMax = 100f;
    public float staminaDegen = 1f;
    public float staminaRegen = 1f;

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

        if (holdingSprintButton){
            if (stamCurrent > 0){
                isSprinting = true;
                stamCurrent -= Time.deltaTime * staminaDegen;
            }
            else{
                isSprinting = false;
            }
        }
        else{
            isSprinting = false;
            if (stamCurrent < stamMax){
                stamCurrent += Time.deltaTime * staminaRegen;
            }
        }
        
    }
}
