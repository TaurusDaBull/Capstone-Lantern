using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class PauseMenu : MonoBehaviour
{
    public GameObject Player;
    public GameObject pauseMenu;
    public GameObject resumeMenu;
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //the user right clicks and runs the KeyPad on Function
            Debug.Log("Pause Menu");
            pauseMenu.SetActive(true);
            StopPlayer();
        }
    }

    private void StopPlayer()
    {
        Player.gameObject.GetComponent<FirstPersonController>().enabled = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0;
        AkSoundEngine.Suspend();
    }
}
