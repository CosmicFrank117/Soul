using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStopper : MonoBehaviour
{
    [SerializeField] float camVelocity = 10f;
    [SerializeField] GameObject player;

    Camera cam;
    Rigidbody rb;
   
    void Start() 
    {
        cam = FindObjectOfType<Camera>();
        rb = cam.GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider other) 
    {
        GetComponent<BoxCollider>().enabled = false;

        StopCamera();

        EnablePlayerControls();
    }

    void StopCamera()
    {
        rb.AddForce(Vector3.forward * -camVelocity, ForceMode.VelocityChange);
    }

    void EnablePlayerControls()
    {
        player.GetComponent<PlayerMovement>().enabled = true;
    }
}
