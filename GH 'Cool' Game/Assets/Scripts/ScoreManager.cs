using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score;
    TMP_Text scoreText;

    void Start() 
    {
        scoreText = GetComponent<TMP_Text>();
        scoreText.text = "Souls Collected: 0";
    }
    
    public void IncreaseScore(int amountToIncrease)
    {
        score += amountToIncrease;
        scoreText.text = "Souls Collected: " + score.ToString();
        Debug.Log(score);
    }

    public void DecreaseScore(int amountToDecrease)
    {
        score -= amountToDecrease;
        scoreText.text = "Souls Collected: " + score.ToString();
        Debug.Log(score);
    }
}
