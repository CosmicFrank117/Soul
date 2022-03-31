using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateManager : MonoBehaviour
{
    [SerializeField] int requiredSouls = 10;

    bool enoughSouls = false;

    ScoreManager scoreManager;
    
    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    void Update()
    {
        if(enoughSouls)
        {
            Debug.Log("Press 'E' to Open");
            PushToOpen();
        } 
    }
    
    void OnTriggerEnter(Collider other) 
    {        
        Debug.Log("The Gate Requires A Part Of You");

        if(scoreManager.score == requiredSouls)
        {
            enoughSouls = true;
        }
    }

    void PushToOpen()
    {
        
        if(Input.GetKeyDown(KeyCode.E))
        {
            scoreManager.DecreaseScore(requiredSouls);
            enoughSouls = false;
        }
    }
}
