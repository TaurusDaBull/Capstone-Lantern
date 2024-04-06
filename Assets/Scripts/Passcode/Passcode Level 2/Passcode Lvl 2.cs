using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class PasscodeLvl2 : MonoBehaviour
{
    [Header("KeyPad")]
    public TMP_Text Passcode;
    public GameObject KeyPad;
    public GameObject CodePanel;
    [Header("Lanterns")]
    public GameObject LanternOnCatch;
    [Header("Lights")]
    public Light LightOnPlayer;
    public Light Beacon;
    
    Color[] CodeColors = new Color[3]; //Setting CodePanel Color
    int LightColor; //CodePanel Color
    int grab; //CodePanel Color buffer
    
    bool TextShown; //Visible text bool

   
    private void Start()
    {

        Invoke("GrabColor", 0.5f);

    }

    public void Update() //Lantern must be thrown to reveal text
    {
        if (LanternOnCatch.activeInHierarchy == true)
        {
            if (LightOnPlayer.color == CodeColors[LightColor])
            {
                Passcode.text = KeyPad.GetComponent<DoorOpen>().Answer;
            }
        

        }
        else
        {
            Passcode.text = " ";
        }
 
    

    } 

    void GrabColor()
    {
        CodeColors[0] = Color.blue;
        CodeColors[1] = Color.yellow;
        CodeColors[2] = Color.green;

        Debug.Log("The color of the Panel is: " + LightColor);
        if (CodePanel.GetComponent<Reveal>().i == grab)
        {
            Debug.Log("Good");
        }
        else if (CodePanel.GetComponent<Reveal>().i != grab)
        {
            Debug.Log("Bad");
            while (CodePanel.GetComponent<Reveal>().i > grab && grab < 3)
            {
                Debug.Log("Changing Color");
                grab++;
                LightColor = grab;
            }

        }
        Debug.Log("The color of the Panel is at end is: " + LightColor);
    }
}
