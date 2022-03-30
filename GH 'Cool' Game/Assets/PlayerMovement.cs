using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed = 5f;
    // [SerializeField] float jumpForce = 5f;
    // [SerializeField] float fallingGravity = -5f;
    
    //public Rigidbody rb;

    bool isGrounded;
    
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Movement();
        //Jumping();
    }

    
    // void OnCollisionStay(Collision other) 
    // {
    //     if(other.gameObject.tag == "Ground")
    //     {
    //     isGrounded = true;
    //     }
    // }
    
    // void OnCollisionExit(Collision other) 
    // {
    //     isGrounded = false;
    // }

    void Movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Translate(Vector3.left * Time.deltaTime * movementSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.Translate(Vector3.back * Time.deltaTime * movementSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Translate(Vector3.right * Time.deltaTime * movementSpeed);
        }
    }

    // void Jumping()
    // {
    //     if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
    //     {
    //         rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    //         isGrounded = false;
    //     }

    //     if(rb.velocity.y < 0)
    //         {
    //             rb.AddForce(Vector3.down * fallingGravity, ForceMode.Acceleration);
    //         }
    // }
}
