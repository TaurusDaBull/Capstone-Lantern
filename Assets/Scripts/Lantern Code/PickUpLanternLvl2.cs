using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class PickUpLanternLvl2 : MonoBehaviour
{
  

    public GameObject LanternOnPlayer; //The Lantern on the Player
    public TMP_Text pickUp; //UI Text
    public AK.Wwise.Event lanternPickUp; //Lantern pick-up sound
    public GameObject ThrowInstructions; //UI instruction
    private bool onceThrow; //bool for single occurence
  

    void Start()
    {
        //At the start of game:
        LanternOnPlayer.SetActive(false);  //Lantern on player not active
        ThrowInstructions.SetActive(false); //Throw instructions don't play at start of game
        onceThrow = false; //bool for single occurence set to false 
 
    }

    private void OnTriggerStay(Collider other)
    {
        //When reach object touches stand
        if(other.gameObject.tag == "Reach")
        {
            //text to Right click is displayed
            pickUp.text = "Right Click to Pick-up";
            //Right mouse button is clicked
            if (Input.GetMouseButton(1))
            {
                //Play sound pick-up sound
                AkSoundEngine.PostEvent("lanternPickUp", gameObject);
                if (onceThrow == false) //single occurence bool must be false
                {
                Invoke("LanternInstruct", 1); //Play Lantern instructions after single second wait
                    onceThrow = true; //single occurence bool is set to true

                }
                this.gameObject.SetActive(false); //Lantern on stand active is set to false
                LanternOnPlayer.SetActive(true); //Lantern on the player is set to true
                pickUp.text = " "; //remove UI text

            }

        }
    }

    private void OnTriggerExit(Collider other)
    {
        //Player leaves proximity of Lantern on stand
        pickUp.text = " "; //clear UI text
    }

    private void LanternInstruct()
    {
        ThrowInstructions.SetActive(true); //Play Lantern instruction animation
    }


    
}
