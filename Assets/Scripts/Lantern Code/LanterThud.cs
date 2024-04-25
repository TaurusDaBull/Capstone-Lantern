using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanterThud : MonoBehaviour
{
    public GameObject LanternOnCatch;
    public AK.Wwise.Event lanternThud;

    

    private void Update()
    {
        //When the Lantern is in proximity of the catch stand
        if (LanternOnCatch.activeInHierarchy == true)
        {
            //Play Lantern thud
            AkSoundEngine.PostEvent("lanternThud", gameObject);
        }
    }


}
