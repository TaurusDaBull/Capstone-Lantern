using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandFloorRespawn : MonoBehaviour
{
    public GameObject RespawnInstructions;

    private bool once;

    private void Start()
    {
        once = false;
    }
    private void OnTriggerEnter(Collider other)
    {
      
        if (other.gameObject.tag == "Lantern" && once == false)
        { 
            Invoke("Respawn", 3);
            RespawnInstructions.SetActive(false);
        }
    }

    private void Respawn()
    {
        RespawnInstructions.SetActive(true);
        once = true;
    }
}
