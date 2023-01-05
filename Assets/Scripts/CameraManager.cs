using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Camera cam;
    public Transform[] cameraPositions;
    public NextRoomTrigger[] cameraTriggers;
    
    public float camSpeed;
    
    private void OnTriggerEnter(Collider other) 
    {
        
    }
    
    void Start()
    {
        
    }

    
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.P))
        {
            StartCoroutine(MoveCamera());
        }
    }

    IEnumerator MoveCamera()
    {
        while (cam.transform.position != cameraPositions[0].position)
            {
                float step = camSpeed * Time.deltaTime;
                cam.transform.position = Vector3.MoveTowards(cam.transform.position,cameraPositions[0].position,step);
                
                if (Vector3.Distance(cam.transform.position, cameraPositions[0].position) < 0.01f)
                {
                    cam.transform.position = cameraPositions[0].position;
                }
                yield return new WaitForEndOfFrame();
            }
    }
}
