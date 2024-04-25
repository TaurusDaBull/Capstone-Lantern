using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
public void OnClick()
    {
        //Log Quit game, quit the game
        Debug.Log("Game Quit");
        Application.Quit();
    }

}
