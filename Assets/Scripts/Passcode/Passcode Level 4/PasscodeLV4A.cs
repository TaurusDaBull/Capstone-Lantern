using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PasscodeLV4A : MonoBehaviour
{
    [Header("KeyPad")]
    public TMP_Text Passcode;
    public GameObject KeyPad;
    public GameObject CodePanel;
    [Header("Lanterns")]
    public GameObject LanternOnPlayer;
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


        if (LanternOnPlayer.activeInHierarchy == true)
        {
            if (LightOnPlayer.color == CodeColors[LightColor])
            {
                Passcode.text = KeyPad.GetComponent<DoorOpenLV4>().PartA;
            }
            else
            {
                Passcode.text = " ";
            }

        }
    

    }


}
