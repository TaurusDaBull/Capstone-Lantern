using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slamDoorOutside : MonoBehaviour
{
    void Start()
    {
        Invoke("doorSlam", 0.3f);
    }

    void doorSlam()
    {
        AkSoundEngine.PostEvent("doorSlamOutside", gameObject);
    }
}
