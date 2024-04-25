using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unlockCursor : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        AkBankManager.LoadBank("titleMusic",false, false);
        Time.timeScale = 1f;
    }



}
