using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSoulChanger : MonoBehaviour
{
    
    [SerializeField] float lightRangeIncreaseAmount = 0.5f;
    [SerializeField] float lightIntensityIncreaseAmount = 0.5f;
    [SerializeField] float innerSphereSizeIncrease = 0.25f;

    Light lightSettings;
    Transform innerSphere;

    void Start() 
    {
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
        innerSphere.localScale = innerSphere.localScale + new Vector3(innerSphereSizeIncrease,innerSphereSizeIncrease,innerSphereSizeIncrease) ;
    }
}
 