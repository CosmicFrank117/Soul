using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{    
    public int score;
    TMP_Text scoreText;
    DeathHandler deathHandler;

    void Start() 
    {
        deathHandler = FindObjectOfType<DeathHandler>();
        scoreText = GetComponent<TMP_Text>();
        scoreText.text = "Souls Collected: 0";
    }

    void Update() 
    {
        if(score < 0)
        {
            deathHandler.HandleDeath();
            scoreText.text = "Souls Collected: 0";
        }
    }
    
    public void IncreaseScore(int amountToIncrease)
    {
        score += amountToIncrease;
        scoreText.text = "Souls Collected: " + score.ToString();
    }

    public void DecreaseScore(int amountToDecrease)
    {
        score -= amountToDecrease;
        scoreText.text = "Souls Collected: " + score.ToString();
    }
}
