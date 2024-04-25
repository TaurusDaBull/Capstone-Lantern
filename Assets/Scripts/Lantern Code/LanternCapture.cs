using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanternCapture : MonoBehaviour
{
    public GameObject LanternOnPlatform;
    public GameObject LanternOnPlayer;
    public GameObject RespawnInstructions;
    public AK.Wwise.Event lanternThud;
    private bool once;
    private void Start()
    {
        //At start the Lantern on the platform is set to False
        LanternOnPlatform.SetActive(false);
      
    }

    private void Update()
    {
        //if Lantern on the Platform on the set to false
        if (LanternOnPlatform.activeInHierarchy == false)
        {
            once = true; //single occurence set to true
        }
    }
    private void OnTriggerStay(Collider other)
    {
        //If Lantern collides with Catch stand
        if (other.gameObject.tag == "Lantern")
        {
          
            if (once == true) //if once occurence is true
            {
                //Wait 3 seconds than run Respawn(), play Lantern thud sound, and set once occurence to false
            Invoke("Respawn", 3);
            AkSoundEngine.PostEvent("lanternThud", gameObject);
            once = false;

            }
            //Copy colors, destroy clones set lantern on stand to true
            //Copy colors, destroy clones set lantern on stand to true
            Destroy(GameObject.Find("Lantern (Stand)(Clone)"));
            Mimic();
            LanternOnPlatform.SetActive(true);

        }
    }
    private void Mimic()
    {
        //Change color of the Lantern on catch stand to color of the Lantern on the player
        LanternOnPlatform.GetComponentInChildren<Light>().color = LanternOnPlayer.GetComponentInChildren<Light>().color;
        LanternOnPlatform.GetComponentInChildren<Light>().intensity = 7.8f;
    }

    void Respawn()
    {
        //Play respawn instruction animation
        RespawnInstructions.SetActive(true);
    }

}
