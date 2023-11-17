using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FPSControl : MonoBehaviour
{
    public TMP_Text FPS;
    bool Present = false;
    private void Start()
    {
     //Making the FPS text inactive in the game's hierarchy
        FPS.gameObject.SetActive(false);
       
    }
    private void Update()
    {
        
        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.LeftControl) && Present == true)
        {
            Present = false;
            Hide();
            if (Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.LeftControl) && Present == false)
            {
                Present = true;
                Show();
            }
       
        }
    }
    void Show()
    {
             FPS.gameObject.SetActive(true);
        
    }

    void Hide()
    {

            FPS.gameObject.SetActive(false);
        
    }
}
