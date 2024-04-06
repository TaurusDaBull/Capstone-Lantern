using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallBoxRespawn : MonoBehaviour
{
    public GameObject RespawnInstructions;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Lantern")
        {


            Invoke("Respawn", 3);
            RespawnInstructions.SetActive(false);
        }
    }

    private void Respawn()
    {
        RespawnInstructions.SetActive(true);
    }
}
