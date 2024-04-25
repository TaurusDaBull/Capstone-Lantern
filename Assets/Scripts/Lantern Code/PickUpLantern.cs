using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class PickUpLantern : MonoBehaviour
{
  

    public GameObject LanternOnPlayer;
    public TMP_Text pickUp;
    public AK.Wwise.Event lanternPickUp;
    public GameObject LanternInstructions;

    void Start()
    {
        //On start hide Lantern Instruction animation and set Lantern on player to false
        LanternOnPlayer.SetActive(false);
        LanternInstructions.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Reach")
        {
            pickUp.text = "Right Click to Pick-up";

            if (Input.GetMouseButton(1))
            {
                //Play sound of Lantern pick-up, Play Lantern animation after one second
                //Set Lantern on stand to false, Set Lantern on Player to true, remove UI text
                AkSoundEngine.PostEvent("lanternPickUp", gameObject);
                Invoke("LanternInstruct", 1);
                this.gameObject.SetActive(false);
                LanternOnPlayer.SetActive(true);
                pickUp.text = " ";

            }

        }
    }

    private void OnTriggerExit(Collider other)
    {
        //Remove UI text when proximity of stand is left
        pickUp.text = " ";
    }

    private void LanternInstruct()
    {
        //Play Lantern Instructions
        LanternInstructions.SetActive(true);
    }

}
