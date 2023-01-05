using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GateManager : MonoBehaviour
{
    [SerializeField] public int requiredSouls = 10;

    [SerializeField] TextMeshProUGUI interactMessage;
    [SerializeField] TextMeshProUGUI doorReqMesage;

    ScoreManager scoreManager;
    PlayerSoulChanger playerSoulChanger;
    Animator animator;
    BoxCollider gateTrigger;

    public bool enoughSouls = false;

    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
        playerSoulChanger = FindObjectOfType<PlayerSoulChanger>();
        gateTrigger = GetComponent<BoxCollider>();
        animator = GetComponent<Animator>();

        doorReqMesage.enabled = false;
        interactMessage.enabled = false;
    }

    void OnTriggerStay(Collider other) 
    {        
        doorReqMesage.enabled = true;

        if(scoreManager.score >= requiredSouls)
        {
            enoughSouls = true;
        }
        if(enoughSouls)
        {
            interactMessage.enabled = true;
            PushToOpen();
        }
    }

    void OnTriggerExit(Collider other) 
    {
        doorReqMesage.enabled = false;
        interactMessage.enabled = false;
    }

    void PushToOpen()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            scoreManager.DecreaseScore(requiredSouls);
            playerSoulChanger.DecreaseLightSizeAndBrighness(requiredSouls);
            playerSoulChanger.DecreaseSphereSize(requiredSouls);
            animator.Play("OpenGate",0);
            gateTrigger.enabled = false;
            doorReqMesage.enabled = false;
            interactMessage.enabled = false;
            enoughSouls = false;
        }
    }
}
