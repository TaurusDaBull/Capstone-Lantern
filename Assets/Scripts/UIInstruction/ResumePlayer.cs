using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class ResumePlayer : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject Player;
    public void OnClick()
    {
    //Log button action, close the pause menu UI
    //Reenable the player's movement, hide the cursor and lock to center
    //Resume game sound, unfreeze world
      Debug.Log("Resume Player");
      pauseMenu.SetActive(false);
      Player.gameObject.GetComponent<FirstPersonController>().enabled = true;
      Cursor.visible = false;
      Cursor.lockState = CursorLockMode.Locked;
      AkSoundEngine.WakeupFromSuspend();
        Time.timeScale = 1;

    }
}
