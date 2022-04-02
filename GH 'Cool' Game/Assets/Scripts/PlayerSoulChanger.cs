using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSoulChanger : MonoBehaviour
{
    
    [SerializeField] float lightRangeIncreaseAmount = 0.05f;
    [SerializeField] float lightIntensityIncreaseAmount = 0.05f;
    [SerializeField] float innerSphereSizeIncrease = 0.05f;

    Light lightSettings;
    Transform innerSphere;
    GateManager gateManager;

    void Start() 
    {
        gateManager = FindObjectOfType<GateManager>();
        lightSettings = GetComponentInChildren<Light>();
        innerSphere = gameObject.GetComponentInChildren<Transform>().transform;
    }
    
    public void IncreaseLightSizeAndBrighness()
    {
        lightSettings.range += lightRangeIncreaseAmount;
        lightSettings.intensity += lightIntensityIncreaseAmount;
    }

    public void IncreaseSphereSize()
    {
        innerSphere.localScale = innerSphere.localScale + new Vector3(innerSphereSizeIncrease,innerSphereSizeIncrease,innerSphereSizeIncrease);
    }

    public void DecreaseLightSizeAndBrighness()
    {
        lightSettings.range -= lightRangeIncreaseAmount * gateManager.requiredSouls;
        lightSettings.intensity -= lightIntensityIncreaseAmount * gateManager.requiredSouls;
    }
    
    public void DecreaseSphereSize()
    {
        float innerSphereSizeDecrease = innerSphereSizeIncrease * gateManager.requiredSouls;
        innerSphere.localScale = innerSphere.localScale + new Vector3(innerSphereSizeDecrease, innerSphereSizeDecrease, innerSphereSizeDecrease);
    }
}
 