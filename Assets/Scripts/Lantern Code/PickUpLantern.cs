using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class PickUpLantern : MonoBehaviour
{
  

    public GameObject LanternOnPlayer;
    public TMP_Text pickUp;

    void Start()
    {
        LanternOnPlayer.SetActive(false);

    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Reach")
        {
            pickUp.text = "Right Click to Pick-up";

            if (Input.GetMouseButton(1))
            {
                this.gameObject.SetActive(false);
                LanternOnPlayer.SetActive(true);
                pickUp.text = " ";

            }

        }
    }

    private void OnTriggerExit(Collider other)
    {
        pickUp.text = " ";
    }


}
