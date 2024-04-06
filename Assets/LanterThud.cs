using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanterThud : MonoBehaviour
{
    public GameObject LanternOnCatch;
    public AK.Wwise.Event lanternThud;

    

    private void Update()
    {
        if (LanternOnCatch.activeInHierarchy == true)
        {
            AkSoundEngine.PostEvent("lanternThud", gameObject);
        }
    }


}
