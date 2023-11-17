using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpawnLantern : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject LanternOnStand;
    public GameObject LanternOnPlayer;
    public TMP_Text pickUp;


    // Update is called once per frame

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Reach" && LanternOnStand.activeInHierarchy == false && LanternOnPlayer.activeInHierarchy == false)
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
