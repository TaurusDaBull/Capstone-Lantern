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
      Debug.Log("Resume Player");
      pauseMenu.SetActive(false);
      Player.gameObject.GetComponent<FirstPersonController>().enabled = true;
      Cursor.visible = false;
      Cursor.lockState = CursorLockMode.Locked;
      AkSoundEngine.WakeupFromSuspend();
        Time.timeScale = 1;

    }
}
