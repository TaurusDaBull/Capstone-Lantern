using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passcode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        System.Random random = new System.Random();
        List<int> arr1 = new List<int> { 1, 2, 3 };
        int a = arr1[random.Next(arr1.Count)];
        arr1.Remove(a);
        int b = arr1[random.Next(arr1.Count)];
        arr1.Remove(b);
        int c = arr1[random.Next(arr1.Count)];
        Debug.Log(string.Format("{0} {1} {2}", a, b, c));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
