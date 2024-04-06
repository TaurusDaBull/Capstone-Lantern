using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopMainMenu : MonoBehaviour
{
    public AK.Wwise.Event Stop;
    // Start is called before the first frame update
    public void stopMusic()
    {
        AkSoundEngine.SetRTPCValue("titleMenu",0f, GameObject.FindGameObjectWithTag("MainMenu"), 1000);

    }

}
