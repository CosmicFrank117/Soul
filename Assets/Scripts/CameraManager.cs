using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Camera cam;
    public Transform[] cameraPositions;
    public List<NextRoomTrigger> cameraTriggers;
    
    public float camSpeed;

    private int targetCam = 0;

    private bool isTriggered;
    
    
    void Start()
    {

    }

    
    void Update()
    {

        if (cameraTriggers[targetCam].isTriggered)
        {
            isTriggered = true;
            //StartCoroutine(MoveCamera(targetCamPos));
            while (cam.transform.position != cameraPositions[targetCam].position)
            {
                float step = camSpeed * Time.deltaTime;
                cam.transform.position = Vector3.MoveTowards(cam.transform.position, cameraPositions[targetCam].position, step);

                if (Vector3.Distance(cam.transform.position, cameraPositions[targetCam].position) < 0.01f)
                {
                    cam.transform.position = cameraPositions[targetCam].position;
                    cameraTriggers[targetCam].isTriggered = isTriggered = false;
                    Destroy(cameraTriggers[targetCam]);
                    cameraTriggers.Remove(cameraTriggers[targetCam]);


                }
            }
        }
    }

    IEnumerator MoveCamera(int targetCam)
    {
      
        
        while (cam.transform.position != cameraPositions[targetCam].position)
        {
            float step = camSpeed * Time.deltaTime;
            cam.transform.position = Vector3.MoveTowards(cam.transform.position, cameraPositions[targetCam].position, step);

            if (Vector3.Distance(cam.transform.position, cameraPositions[targetCam].position) < 0.01f)
            {
                cam.transform.position = cameraPositions[targetCam].position;
                cameraTriggers[targetCam].isTriggered = isTriggered = false;
                Destroy(cameraTriggers[targetCam]);
                cameraTriggers.Remove(cameraTriggers[targetCam]);
                

            }
            yield return new WaitForEndOfFrame();
        }
        
    }
}
