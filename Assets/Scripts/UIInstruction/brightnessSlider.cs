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
        //At start set brightness to zero
        brightness.value = 0;
    }
    void Update()
    {
        //On update match slider value to brightness value
        enviroLight.intensity = brightness.value;
    }

}
