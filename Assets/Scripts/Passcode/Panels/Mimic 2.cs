using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mimic2 : MonoBehaviour
{
    public RevealGrabber panelB;
    public Material[] RBY;
    public GameObject thisOne;

    void Update()
    {
        int colorPicker = 0;
        colorPicker = panelB.GetComponent<RevealGrabber>().i;
        Debug.Log("The color of the door panel B is " + colorPicker);
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

            default:
                Debug.Log("Something is wrong");
                break;

        }

    }

}
