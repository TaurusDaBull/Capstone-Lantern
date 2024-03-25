using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RevealMultiPanel : MonoBehaviour
{
    [Header("Materials")]
    public Material[] Mat = new Material[3];
    [Header("Panels")]
    public GameObject[] Panels = new GameObject[3];
    [Header("Passcodes")]
    public PasscodeLV3A passcode0;
    public PasscodeLV3B passcode1;
    public PasscodeLV3C passcode2;


    public string[] panels = new string[3];

    public void Start()
    {
        //Random number to assign to panels for material labeling
        List<string> nums = new List<string>() { "0","1","2" };
        
       System.Random rand = new System.Random ();
        for (int i = 0; i < 3; i++)
        {
            int index = rand.Next(nums.Count);
            string test = nums[index];
            panels[i] = test;
            nums.Remove(test);
        }
               
        SetColor();

    }

    public void SetColor()
    {
        for (int i = 0; i < 3; i++)
        {
            int just = Int32.Parse(panels[i]);
            Panels[i].GetComponent<RevealGrabber>().i = just;
        }
        Debug.Log("A is: " + panels[0]);
        Debug.Log("B is: " + panels[1]);
        Debug.Log("C is: " + panels[2]);
    }

    public void Update()
    {

        passcode0.GetComponent<PasscodeLV3A>().LightColor = Int32.Parse(panels[0]);
        passcode1.GetComponent<PasscodeLV3B>().LightColor = Int32.Parse(panels[1]);
        passcode2.GetComponent<PasscodeLV3C>().LightColor = Int32.Parse(panels[2]);

    }

}
