using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class brightnessSlider : MonoBehaviour
{
    public Slider brightness;
    public Light enviroLight;

    private void Start()
    {
        brightness.value = 0;
    }
    void Update()
    {
        enviroLight.intensity = brightness.value;
    }

}
