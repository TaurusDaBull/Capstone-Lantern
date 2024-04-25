using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slamDoor : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke("doorSlam", 0.3f);
    }

    void doorSlam()
    {
        AkSoundEngine.PostEvent("doorSlam", gameObject);
    }
}
