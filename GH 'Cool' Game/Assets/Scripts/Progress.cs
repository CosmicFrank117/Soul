using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Progress : MonoBehaviour
{
    [SerializeField] float camMoveDistance = 18f;
    [SerializeField] Collider player;

    Camera cam;
    
    void Start() 
    {
        cam = FindObjectOfType<Camera>();
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
        cam.transform.Translate(Vector3.forward * camMoveDistance, Space.World);
    }
}
