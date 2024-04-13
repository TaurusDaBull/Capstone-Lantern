using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class NextLevel5 : MonoBehaviour
{
    public GameObject Player;
    public GameObject fadeOut;
    public AK.Wwise.Event stairsNextLevel;


    private void OnTriggerEnter(Collider other)
    {
        //If the player is in contact of the object
        if (other.gameObject.tag == "Player")
        {
            //Stop Player
            StopPlayer();
            //Fade Out
            FadeOut();
            //Foot steps

            //ScreenManager will move the player to the next designated level
            Invoke("NextLevelFinal", 3.5f);
        }
    }

    void StopPlayer()
    {
        Player.gameObject.GetComponent<FirstPersonController>().enabled = false;
    }

    void FadeOut()
    {
        fadeOut.SetActive(true);
        AkSoundEngine.PostEvent("stairsNextLevel", gameObject);
    }

    void NextLevelFinal()
    {
        SceneManager.LoadScene("Ending");
        AkSoundEngine.SetState("inGame", "levelTransition");
    }
}
