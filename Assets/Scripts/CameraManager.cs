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
    
    void Update()
    {

        if (cameraTriggers[targetCam].isTriggered)
        {
            StartCoroutine(MoveCamera(targetCam));
            
            if (targetCam < cameraPositions.Length - 1)
            {
                targetCam++;
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
                cameraTriggers[targetCam].isTriggered = false;

                if (targetCam == cameraTriggers.Count - 1)
                {
                    GetComponent<YouWin>().EnableWinText();
                }

                Destroy(cameraTriggers[targetCam]);
            }
            yield return new WaitForEndOfFrame();
        }
    }
}
