using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSoulChanger : MonoBehaviour
{
    
    [SerializeField] float lightRangeIncreaseAmount = 0.5f;
    [SerializeField] float lightIntensityIncreaseAmount = 0.5f;

    Light lightSettings;

    void Start() 
    {
        lightSettings = GetComponentInChildren<Light>();
    }
    
    public void IncreaseLightSizeAndBrighness()
    {
        lightSettings.range += lightRangeIncreaseAmount;
        lightSettings.intensity += lightIntensityIncreaseAmount;
    }

    
}
