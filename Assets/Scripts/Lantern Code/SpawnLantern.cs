using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpawnLantern : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject LanternOnStand;
    public GameObject LanternOnPlayer;
    public GameObject LanternOnPlatform;
    public Light Beacon;
    public TMP_Text pickUp;

    private void Start()
    {
        Beacon.gameObject.SetActive(true); // Light to illuminate the Lantern Starting stand set to true
    }

    private void Update()
    {
        //if Lantern on the Stand is false and lantern on player is also set to false 
        if (LanternOnStand.activeInHierarchy == false && LanternOnPlayer.activeInHierarchy == false)
        {
            Beacon.gameObject.SetActive(true); //Light to illuminate the beacon is set to true
        }
    }
    private void OnTriggerStay(Collider other)
    {
        //When player is in proximity of the stand
        //if Lantern on the Stand is false and lantern on player is also set to false 
        if (LanternOnStand.activeInHierarchy == false && LanternOnPlayer.activeInHierarchy == false)
        {
            
            pickUp.text = "Left Click to Respawn"; //UI Text Left Click
            if (Input.GetMouseButton(0)) //Left Mouse button pressed
            {
                //Respawn Lantern, Destroy Clone , Lantern on throw stand is removed
                LanternOnStand.gameObject.SetActive(true);
                Destroy(GameObject.Find("Lantern (Stand)(Clone)"));
                LanternOnPlatform.gameObject.SetActive(false);



            }

        }
    }

}
