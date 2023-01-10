using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextRoomTrigger : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] Animator gateAnimator;

    public bool isTriggered = false;

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
        if (player) player.GetComponent<PlayerMovement>().enabled = true;
    }
}
