using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpawnLanternLV1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject LanternOnStand;
    public GameObject LanternOnPlayer;
    public GameObject LanternOnPlatform;
    public TMP_Text pickUp;


    private void OnTriggerStay(Collider other)
    {
        if (LanternOnStand.activeInHierarchy == false && LanternOnPlayer.activeInHierarchy == false)
        {

            pickUp.text = "Left Click to Respawn";
            if (Input.GetMouseButton(0))
            {
                LanternOnStand.gameObject.SetActive(true);
                Destroy(GameObject.Find("Lantern (Stand)(Clone)"));


            }

        }
    }

}
