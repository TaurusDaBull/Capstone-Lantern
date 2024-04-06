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
        LanternOnPlatform.SetActive(false);
      
    }

    private void Update()
    {
        if (LanternOnPlatform.activeInHierarchy == false)
        {
            once = true;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Lantern")
        {
          
            if (once == true)
            {
            Invoke("Respawn", 3);
            AkSoundEngine.PostEvent("lanternThud", gameObject);
            once = false;

            }

            Destroy(GameObject.Find("Lantern (Stand)(Clone)"));
            Mimic();
            LanternOnPlatform.SetActive(true);

        }
    }
    private void Mimic()
    {
        LanternOnPlatform.GetComponentInChildren<Light>().color = LanternOnPlayer.GetComponentInChildren<Light>().color;
        LanternOnPlatform.GetComponentInChildren<Light>().intensity = 7.8f;
    }

    void Respawn()
    {
        RespawnInstructions.SetActive(true);
    }

}
