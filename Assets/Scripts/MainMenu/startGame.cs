using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour
{
    public GameObject fadeIn;

    public void Awake()
    {
        Time.timeScale = 1.0f;
    }
    public void showMouse()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
    public void onClick()
    {
        fadeIn.SetActive(true);
        AkSoundEngine.SetRTPCValue("Play", 0f, GameObject.FindGameObjectWithTag("MainMenu"), 1000);
        
    }
 
}
