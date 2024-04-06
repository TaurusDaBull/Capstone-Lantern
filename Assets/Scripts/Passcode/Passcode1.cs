using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using TMPro;
using UnityEngine;


public class Passcode1 : MonoBehaviour
{
    public TMP_Text Passcode;
    public GameObject LanternOnPlayer;
    public Light LightOnPlayer;
    public Light LightOnStand;
    public GameObject KeyPad;
    public GameObject Reveal;
    Color[] CodeColors = new Color[3];
    int LightColor;
    int grab;
    
    bool TextShown;

    // Start is called before the first frame update
    private void Start()
    {
        
        CodeColors[0] = Color.blue;
        CodeColors[1] = Color.yellow;
        CodeColors[2] = Color.green;
       
        Debug.Log("The color of the Text is: " + LightColor);
        if(Reveal.GetComponent<Reveal>().i == grab)
        {
            Debug.Log("Good");
        }
        else if(Reveal.GetComponent<Reveal>().i != grab)
        {
            Debug.Log("Bad");
            while (Reveal.GetComponent<Reveal>().i > grab && grab < 3)
            {
                Debug.Log("Changing Color");
                grab++;
                LightColor = grab;
            }
            
            

        }

    }

    public void Update()
    {
        if (LanternOnPlayer.activeInHierarchy == true)
        {
            TextShown = true;
            if (TextShown == true && LightOnPlayer.color == CodeColors[LightColor])
            {
                Passcode.text = KeyPad.GetComponent<DoorOpen>().Answer;
            }
            else
            {
                Passcode.text = " ";
            }

        }

    } 
}
