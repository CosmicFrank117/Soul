using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulCollision : MonoBehaviour
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
        scoreManager.IncreaseScore(amountToIncrease);
        
        playerSoulChanger.IncreaseLightSizeAndBrighness();
        playerSoulChanger.IncreaseSphereSize();
        
        Destroy(gameObject);
    }
}
