using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
public void OnClick()
    {
        Debug.Log("Game Quit");
        Application.Quit();
    }

}
