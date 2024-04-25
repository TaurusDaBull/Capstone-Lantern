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
       //Press the ESC button
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Log Pause Menu press, set the pause menu to active, stop the player and world
            Debug.Log("Pause Menu");
            pauseMenu.SetActive(true);
            StopPlayer();
        }
    }

    private void StopPlayer()
    {
        //Disable the player's movement, make cursor available,
        //unlock the cursor, pause the world, suspend the in game music
        Player.gameObject.GetComponent<FirstPersonController>().enabled = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0;
        AkSoundEngine.Suspend();
    }
}
