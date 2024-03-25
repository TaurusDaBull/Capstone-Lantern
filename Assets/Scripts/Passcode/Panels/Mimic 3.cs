using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mimic3 : MonoBehaviour
{
    public RevealGrabber panelC;
    public Material[] RBY;
    public GameObject thisOne;


    void Update()
    {
        int colorPicker = 0;
        colorPicker = panelC.GetComponent<RevealGrabber>().i;
        Debug.Log("The color of the door panel is " + colorPicker);
        switch (colorPicker)
        {
            case 0:
                thisOne.GetComponent<Renderer>().material = RBY[0];
                break;
            case 1:
                thisOne.GetComponent<Renderer>().material = RBY[1];
                break;
            case 2:
                thisOne.GetComponent<Renderer>().material = RBY[2];
                break;

        }

    }
}
