//Shady
using UnityEngine;
using UnityEngine.XR;

[ExecuteInEditMode]
public class Reveal : MonoBehaviour
{
 public Material[] Mat = new Material[3];
 public GameObject Panel;
 public Light SpotLight;
 public int i;

    public void Start()
    {
       SetColor();
    }

    public void SetColor()
    {
        //Creating a instance of a randomfunction
        System.Random rand = new System.Random();
        //integer i is set using the random number
        i = rand.Next(0, 3);
        Debug.Log("The color on the panel is: " + i);
    }

    void Update ()
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
}//class end