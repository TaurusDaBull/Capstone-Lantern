using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowFPS : MonoBehaviour
{
    public GameObject fps;
    private bool active;

    private void Start()
    {
        active = false;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftAlt) && active == false)
        {
            fps.SetActive(true);
            active = true;
            
        }
        if (Input.GetKeyDown(KeyCode.LeftControl) && active == true)
        {
            fps.SetActive(false);
            active = false;

        }
    }
}
