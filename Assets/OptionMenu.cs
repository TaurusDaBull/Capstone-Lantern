using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionMenu : MonoBehaviour
{
    public GameObject options;
    public GameObject[] pauseMenuButtons;
public void OnClick()
    {
        for (int i = 0; i < pauseMenuButtons.Length; i++)
        { pauseMenuButtons[i].SetActive(false); }
        options.SetActive(true);
        Debug.Log("Option Menu Buttons");

    }


}
