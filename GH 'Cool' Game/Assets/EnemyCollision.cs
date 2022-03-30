using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
        [SerializeField] int amountToIncrease = 1;

        ScoreManager scoreManager;
        PlayerSoulChanger playerSoulChanger;
    
    void Start() 
    {
        scoreManager = FindObjectOfType<ScoreManager>();
        playerSoulChanger = FindObjectOfType<PlayerSoulChanger>();
    }

    void OnCollisionEnter(Collision other) 
    {
        
        Debug.Log("big collision");
        scoreManager.IncreaseScore(amountToIncrease);
        playerSoulChanger.IncreaseLightSizeAndBrighness();
        Destroy(gameObject);
        
    }
}
