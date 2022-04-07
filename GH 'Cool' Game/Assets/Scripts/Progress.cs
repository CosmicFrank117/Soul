using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Progress : MonoBehaviour
{
    [SerializeField] float camMoveDistance = 18f;
    [SerializeField] float camVelocity = 10f;
    [SerializeField] Collider player;

    Camera cam;
    Rigidbody rb;

    void Start() 
    {
        cam = FindObjectOfType<Camera>();
        rb = cam.GetComponent<Rigidbody>();
    }

    void Update()
    {
    }

    void OnTriggerEnter(Collider other) 
    {
        if(other == player)
        {   
            GetComponent<BoxCollider>().enabled = false;
            
            CloseGate();

            MoveCamera();
        }
    }

    void CloseGate()
    {
        Debug.Log("Door Will Close");
    }

    void MoveCamera()
    {
        rb.AddForce(Vector3.forward * camVelocity);
    }
}
