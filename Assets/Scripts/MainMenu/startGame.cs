using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour
{
    public GameObject fadeIn;
    public void onClick()
    {
        fadeIn.SetActive(true);
        AkSoundEngine.SetRTPCValue("Play", 0f, GameObject.FindGameObjectWithTag("MainMenu"), 1000);
        
    }
 
}
