using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
     public void Update()
    {
        //Play bell sound to start game
        AkSoundEngine.SetState("Main", "startingGame");
    }

}
