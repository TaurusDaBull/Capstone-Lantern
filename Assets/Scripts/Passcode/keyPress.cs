using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyPadPress : MonoBehaviour
{
    
    public AK.Wwise.Event keyPress;
    public void onClick()
    {
       
        AkSoundEngine.PostEvent("keyPadPressed", gameObject);
    }
}
