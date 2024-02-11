using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ChangeColor : MonoBehaviour
{
    public Light SpotLight;

    private void Start()
    {
        SpotLight.color = Color.yellow;
    }
    // Update is called once per frame
    void Update()
    {

        //Scroll up on scroll wheel will change color "Scrolling Forward"
        if (SpotLight.color == Color.green && Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            SpotLight.color = Color.yellow;
            return;
        }

        if (SpotLight.color == Color.yellow && Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            SpotLight.color = Color.blue;
            return;
        }

        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            SpotLight.color = Color.green;
            return;
        }



        //Scroll up on scroll wheel will change color "Scrolling Backwards"
        if (SpotLight.color == Color.green && Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            SpotLight.color = Color.blue;
            return;
        }

        if (SpotLight.color == Color.yellow && Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            SpotLight.color = Color.green;
            return;
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            SpotLight.color = Color.yellow;
            return;
        }

    }
}
//Spot light colors need to cycle from Yellow -> Blue -> Green than back to Yellow