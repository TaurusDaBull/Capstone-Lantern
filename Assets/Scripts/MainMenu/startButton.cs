using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startButton : MonoBehaviour
{
    public void mainMenuStart()
    {

        //Play Start sound
        AkSoundEngine.PostEvent("Start", gameObject);


    }
}
