using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class removeFade : MonoBehaviour
{
public GameObject fade;
    public float X;
    void Update()
    {
        
        X += Time.deltaTime;

        if (X > 6)
        {
            fade.SetActive(false);
        }
    }

 
}
