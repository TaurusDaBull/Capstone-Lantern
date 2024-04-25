using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class optionsBack : MonoBehaviour
{
    public GameObject options;
    public GameObject[] pauseMenuButtons;
    public void OnClick()
    {
        for (int i = 0; i < pauseMenuButtons.Length; i++)
        { pauseMenuButtons[i].SetActive(true); }
        options.SetActive(false);
        Debug.Log("Back");

    }
}
