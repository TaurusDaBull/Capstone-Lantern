using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        //If the player is in contact of the object
        if (other.gameObject.tag == "Player")
            Debug.Log("Next Level");
        //ScreenManager will move the player to the next designated level
        SceneManager.LoadScene("Lvl 2.2");
        AkSoundEngine.SetState("inGame", "levelTransition");

    }
}
