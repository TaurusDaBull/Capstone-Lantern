using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PasscodeLV3C : MonoBehaviour
{
    public TMP_Text Passcode;
    public GameObject LanternOnPlayer;
    public Light LightOnPlayer;
    public GameObject KeyPad;
    public GameObject Reveal;

    Color[] CodeColors = new Color[3];
    public int LightColor;


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


        if (LanternOnPlayer.activeInHierarchy == true)
        {


            TextShown = true;
            if (TextShown == true && LightOnPlayer.color == CodeColors[LightColor])
            {


                Passcode.text = KeyPad.GetComponent<DoorOpenLV3>().PartC;


            }
            else
            {
                Passcode.text = " ";
            }

        }

    }
}
