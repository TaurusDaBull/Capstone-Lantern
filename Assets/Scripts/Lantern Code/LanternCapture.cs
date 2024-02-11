using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanternCapture : MonoBehaviour
{
    public GameObject LanternOnPlatform;
    public GameObject LanternOnPlayer;

    private void Start()
    {
        LanternOnPlatform.SetActive(false);
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Lantern")
        {
            Debug.Log("Capture");
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
