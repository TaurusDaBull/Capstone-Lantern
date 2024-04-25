using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpawnLanternLV1 : MonoBehaviour
{
    
    public GameObject LanternOnStand;
    public GameObject LanternOnPlayer;
    public GameObject LanternOnPlatform;
    public TMP_Text pickUp;


    private void OnTriggerStay(Collider other)
    {
        //If Lantern on Stand and Lantern on Player are false
        if (LanternOnStand.activeInHierarchy == false && LanternOnPlayer.activeInHierarchy == false)
        {

            pickUp.text = "Left Click to Respawn"; //UI text
            if (Input.GetMouseButton(0)) //Left Mouse button is pressed
            {
                //Set the Lantern on Stand to active, remove clones
                LanternOnStand.gameObject.SetActive(true);
                Destroy(GameObject.Find("Lantern (Stand)(Clone)"));


            }

        }
    }

}
