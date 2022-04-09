using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    [SerializeField] int amountToDecrease = 3;

    ScoreManager scoreManager;
    PlayerSoulChanger playerSoulChanger;

    void Start() 
    {
        scoreManager = FindObjectOfType<ScoreManager>();
        playerSoulChanger = FindObjectOfType<PlayerSoulChanger>();
    }

    void OnCollisionEnter(Collision other) 
    {
        scoreManager.DecreaseScore(amountToDecrease);
        
        playerSoulChanger.DecreaseLightSizeAndBrighness(amountToDecrease);
        playerSoulChanger.DecreaseSphereSize(amountToDecrease);
        
        Destroy(gameObject);
    }
}
