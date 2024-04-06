using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class PickUpLanternLvl2 : MonoBehaviour
{
  

    public GameObject LanternOnPlayer;
    public TMP_Text pickUp;
    public AK.Wwise.Event lanternPickUp;
    public GameObject ThrowInstructions;
    private bool onceThrow;
  

    void Start()
    {
        LanternOnPlayer.SetActive(false);
        ThrowInstructions.SetActive(false);
        onceThrow = false;
 
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Reach")
        {
            pickUp.text = "Right Click to Pick-up";

            if (Input.GetMouseButton(1))
            {
                AkSoundEngine.PostEvent("lanternPickUp", gameObject);
                if (onceThrow == false)
                {
                Invoke("LanternInstruct", 1);
                    onceThrow = true;

                }
                this.gameObject.SetActive(false);
                LanternOnPlayer.SetActive(true);
                pickUp.text = " ";

            }

        }
    }

    private void OnTriggerExit(Collider other)
    {
        pickUp.text = " ";
    }

    private void LanternInstruct()
    {
        ThrowInstructions.SetActive(true);
    }


    
}
