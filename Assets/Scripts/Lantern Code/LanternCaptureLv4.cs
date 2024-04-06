using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanternCaptureLv4 : MonoBehaviour
{
    public GameObject LanternOnPlatform;
    public GameObject LanternOnPlayer;
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



}
