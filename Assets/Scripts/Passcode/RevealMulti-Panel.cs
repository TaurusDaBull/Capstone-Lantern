using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevealMultiPanel : MonoBehaviour
{
    public Material[] Mat = new Material[3];
    public GameObject[] Panels = new GameObject[3];
    public Light SpotLight;
    private int a;
    private int b;
    private int c;
    public GameObject[] Passcodeslv3;
    public RevealGrabber PanelSecond;
    public RevealGrabber PanelThird;
    public void Start()
    {
        // SetColor();
        System.Random rand = new System.Random();
        List<int> arr1 = new List<int> { 0, 1, 2 };
        a = arr1[rand.Next(arr1.Count)];
        Debug.Log("The Length is: " + Passcodeslv3.Length);
        Debug.Log("Main Panel is: " + a);
    }

    public void SetColor()
    {
        //Creating a instance of a randomfunction
        System.Random rand = new System.Random();
        List<int> arr1 =new List<int> { 0, 1, 2 };
        a = arr1[rand.Next(arr1.Count)];
        Passcodeslv3[1].GetComponent<PasscodeLV3>().LightColor = a;
        Debug.Log("Main Panel is: " + a);
        arr1.Remove(a);
        

        b = arr1[rand.Next(arr1.Count)];
        PanelSecond.i = b;
        Passcodeslv3[2].GetComponent<PasscodeLV3>().LightColor = b;
        Debug.Log("Panel 2 is: " + b);
        arr1.Remove(b);

        c = arr1[rand.Next(arr1.Count)];
        PanelThird.i = c;
        Passcodeslv3[3].GetComponent<PasscodeLV3>().LightColor = c;
        Debug.Log("Panel 3 is: " + c);
    }


       void Update()
       {
           //The renderer of the Game Object Panel is is set by using the material set at the random integer array position 
           Panels[0].GetComponent<Renderer>().material = Mat[a];
           try
           {
               Mat[a].SetVector("MyLightPosition", SpotLight.transform.position);
               Mat[a].SetVector("MyLightDirection", -SpotLight.transform.forward);
               Mat[a].SetFloat("MyLightAngle", SpotLight.spotAngle);
           }
           catch
           {
               Debug.Log("Out of Bounds");
           }
       }
    
}
