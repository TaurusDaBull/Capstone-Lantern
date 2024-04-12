using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class NextLevel3 : MonoBehaviour
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
            Invoke("NextLevelthird", 3.5f);
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

    void NextLevelthird()
    {
        SceneManager.LoadScene("Lvl 3.2");
        AkSoundEngine.SetState("inGame", "levelTransition");
    }
}
