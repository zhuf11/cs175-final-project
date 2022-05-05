using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 20.0f;
    public float jumpForce = 5.0f;
    public CharacterController controller;

    private Vector3 moveDirection;
    public float gravityScale = 1.0f;
    
    //Rigidbody playerRb;

    // Start is called before the first frame update
    void Start()
    {
        //playerRb = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // playerRb.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, playerRb.velocity.y, Input.GetAxis("Vertical") * moveSpeed);

        // if (Input.GetButtonDown("Jump"))
        // {
        //     playerRb.velocity =  new Vector3(playerRb.velocity.x, jumpForce, playerRb.velocity.z);
        // }
        moveDirection = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, 0f , Input.GetAxis("Vertical") * moveSpeed);

        if (Input.GetButtonDown("Jump"))
        {   
            moveDirection.y = jumpForce;
        }

        moveDirection.y = moveDirection.y + (Physics.gravity.y * gravityScale);

        controller.Move(moveDirection * Time.deltaTime);
    }
}
