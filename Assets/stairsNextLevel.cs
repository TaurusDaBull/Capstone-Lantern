using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stairsNextLevel : MonoBehaviour
{

    void Start()
    {
        AkSoundEngine.PostEvent("stairsNextLevel", gameObject);
    }


}
