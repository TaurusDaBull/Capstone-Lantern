using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PasscodeLV4B : MonoBehaviour
{
    [Header("KeyPad")]
    public TMP_Text Passcode;
    public GameObject KeyPad;
    public GameObject CodePanel;
    [Header("Lanterns")]
    public GameObject LanternOnCatch;
    [Header("Lights")]
    public Light LightOnPlayer;


    Color[] CodeColors = new Color[3];
    public int LightColor;
    int grab; //CodePanel Color buffer


    bool TextShown;

    // Start is called before the first frame update
    private void Start()
    {


        CodeColors[0] = Color.blue;
        CodeColors[1] = Color.yellow;
        CodeColors[2] = Color.green;
        Debug.Log("The Light Color is: " + LightColor);


    }

    public void Update()
    {


        if (LanternOnCatch.activeInHierarchy == true)
        {
            if (LightOnPlayer.color == CodeColors[LightColor])
            {
                Passcode.text = KeyPad.GetComponent<DoorOpenLV4>().PartB;
            }


        }
        else
        {
            Passcode.text = " ";
        }

    }

/*    void GrabColor()
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
    }*/
}
