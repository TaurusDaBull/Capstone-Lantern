using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuMusic : MonoBehaviour
{
    public AK.Wwise.Event MainMenu;
    // Start is called before the first frame update
    void Start()
    {
        

        AkSoundEngine.PostEvent("Play", gameObject);
      
       
    }



}
