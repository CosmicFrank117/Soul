using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextRoomTrigger : MonoBehaviour
{
    [SerializeField] float camVelocity = 10f;
    [SerializeField] GameObject player;
    [SerializeField] Animator gateAnimator;

    Camera cam;
    Rigidbody rb;

    public bool isTriggered = false;

    void Start() 
    {
        cam = FindObjectOfType<Camera>();
        rb = cam.GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider other) 
    {
        if(other == player.GetComponent<Collider>())
        {   
            GetComponent<BoxCollider>().enabled = false;
            
            CloseGate();
            
            StopPlayerControls();

            isTriggered = true;
            
        }
    }

    void CloseGate()
    {
        gateAnimator.Play("CloseGate",0);
    }

    void StopPlayerControls()
    {
        player.GetComponent<PlayerMovement>().enabled = false;
    }

    private void OnDestroy()
    {
        player.GetComponent<PlayerMovement>().enabled = true;
    }
}
