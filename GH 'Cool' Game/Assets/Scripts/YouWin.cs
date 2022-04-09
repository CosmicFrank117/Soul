using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class YouWin : MonoBehaviour
{
    [SerializeField] TMP_Text youWinText;
    
    void Start() 
    {
        youWinText.enabled = false;
    }
    
    void OnTriggerEnter(Collider other) 
    {
        youWinText.enabled = true;
    }
}
