using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouWin : MonoBehaviour
{
    public GameObject youWinCanvas;
    
    void Start() 
    {
        youWinCanvas.SetActive(false);
    }

    public void EnableWinText()
    {
        youWinCanvas.SetActive(true);
    }
}
