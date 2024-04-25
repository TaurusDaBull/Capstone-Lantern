using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanternCaptureLv4 : MonoBehaviour
{
    public GameObject LanternOnPlatform; //Lantern on Stand to be thrown at
    public GameObject LanternOnPlayer; //Lantern asset on Player
    public AK.Wwise.Event lanternThud; //Sound of Lantern hitting stand
    private bool once; //bool to ensure event occurs once
    private void Start()
    {
        //When game starts, Lantern on throw stand is not active
        LanternOnPlatform.SetActive(false);
      
    }

    private void Update()
    {
        //Set to bool on start to true
        if (LanternOnPlatform.activeInHierarchy == false)
        {
            once = true;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        //When the Lanten touches the stand, Destory created clone copy the color of the light on the player, and set the Lantern on the throw stand to true
        if (other.gameObject.tag == "Lantern")
        {
          //if once is true, play the "thud" sound
            if (once == true)
            {
            AkSoundEngine.PostEvent("lanternThud", gameObject); //Thud sound played
            once = false; //bool set to false

            }

            Destroy(GameObject.Find("Lantern (Stand)(Clone)")); //Find all clone assets with designated name and destroy
            Mimic(); //Copy color of the Lantern on the plaayer
            LanternOnPlatform.SetActive(true); //Set the Lantern on the stand to active

        }
    }
    private void Mimic()
    {
        //Change color of the Lantern on the throw stand to the Lantern color on the player
        LanternOnPlatform.GetComponentInChildren<Light>().color = LanternOnPlayer.GetComponentInChildren<Light>().color;
        //Increase brightness of the Light in the throw stand
        LanternOnPlatform.GetComponentInChildren<Light>().intensity = 7.8f;
    }



}
