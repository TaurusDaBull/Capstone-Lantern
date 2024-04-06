using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startButton : MonoBehaviour
{
    // Start is called before the first frame update

    // Start is called before the first frame update
    public void mainMenuStart()
    {


        AkSoundEngine.PostEvent("Start", gameObject);


    }
}
