using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    private AK.Wwise.State inMenu;
    // Update is called once per frame
     public void Update()
    {

        AkSoundEngine.SetState("Main", "startingGame");
    }

}
