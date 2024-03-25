using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mimic : MonoBehaviour
{
    public RevealGrabber panelA;
    public Material[] RBY;
    public GameObject thisOne;

    // Start is called before the first frame update
    void Update()
    {
        int colorPicker = 0;
        colorPicker = panelA.GetComponent<RevealGrabber>().i;
        Debug.Log ("The color of the door panel is " + colorPicker);
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
