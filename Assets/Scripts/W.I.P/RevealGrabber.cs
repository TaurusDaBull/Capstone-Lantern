using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevealGrabber : MonoBehaviour
{
    public Material[] Mat = new Material[3];
    public GameObject Panel;
    public Light SpotLight;
    public int i;


    // Update is called once per frame
    void Update()
    {
        //The renderer of the Game Object Panel is is set by using the material set at the random integer array position 
        Panel.GetComponent<Renderer>().material = Mat[i];
        try
        {
            Mat[i].SetVector("MyLightPosition", SpotLight.transform.position);
            Mat[i].SetVector("MyLightDirection", -SpotLight.transform.forward);
            Mat[i].SetFloat("MyLightAngle", SpotLight.spotAngle);
        }
        catch
        {
            Debug.Log("Out of Bounds");
        }
    }

}
