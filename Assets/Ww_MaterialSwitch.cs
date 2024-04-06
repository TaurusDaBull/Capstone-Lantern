using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ww_MaterialSwitch : MonoBehaviour
{
    public string SwitchGroup = "Footsteps";
    public string Switch = "stone";
    public GameObject Character;

    private void OnTriggerEnter(Collider other)
    {
        AkSoundEngine.SetSwitch(SwitchGroup, Switch, Character);
    }
}
