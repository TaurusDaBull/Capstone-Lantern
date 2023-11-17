using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.Pool;

public class Throwing : MonoBehaviour
{
    public Transform Cam;
    public Transform AttackPoint;
    public GameObject ObjectToThrow;
    public GameObject ObjectOnPlayer;
    Color grab;
    public List<GameObject> LanternClones;

    public KeyCode ThrowKey = KeyCode.Mouse1;
    public float ThrowForce;
    public float ThrowUpwardForce;

    public bool ReadyToThrow;

    // Update is called once per frame
    private void Start()
    {
        //At the start of the game the player cannot throw the lantern until the lantern is on the player is active
        ReadyToThrow = false;
    }

    void Update()
    {
        //Once the lantern on the player is active, the "Ready to throw" boolean becomes true
        if (ObjectOnPlayer.activeInHierarchy)
        {
            ReadyToThrow = true;
            //The throw key is set to "E", if "E" is pressed while the "Ready to throw" boolean is true
            if (Input.GetKeyDown(ThrowKey) && ReadyToThrow)
            {
                //The player will call the throw function
                Throw();
            }
        }
    }

    private void Throw()
    {
        //At the start of the Throw function the "Ready to Throw" boolean is set to false
        ReadyToThrow = false;
        //Elements of the Object that is being thrown needs reference information from the base lantern and therefore becomes active in the hierarchy
        ObjectToThrow.SetActive(true); 
        //The mass of the object is changed to 40
        ObjectToThrow.GetComponent<Rigidbody>().mass = 40.0f;
        //The intesity of the light is set to 7.8
        ObjectToThrow.GetComponentInChildren<Light>().intensity = 7.8f;
        //The color of the lantern that is on the player and is applied to the lantern that is being thrown
        ObjectToThrow.GetComponentInChildren<Light>().color = ObjectOnPlayer.GetComponentInChildren<Light>().color;
        //An instance of this object is created as a projectile.
        GameObject projectile = Instantiate(ObjectToThrow, AttackPoint.position, Cam.rotation);
        //The lantern's original mass is set back to 30
        ObjectToThrow.GetComponent<Rigidbody>().mass = 30.0f;
        //The Lantern copy than becomes inactive in the heirarchy
        ObjectToThrow.SetActive(false);
        //The clone of the Lantern is added to a list that will be deleted later
        LanternClones.Add(GameObject.Find("Lantern (Stand)(Clone)"));
        DestroyClone();
        Debug.Log("Lantern Added to List");
        //A rigidbody is created for the projectile and applied to the projectile
        Rigidbody ProjectileRB = projectile.GetComponent<Rigidbody>();
        //The throw force is created based on the position of the players camera to include a throw force and upward force
        Vector3 ForcetoAdd = Cam.transform.forward * ThrowForce + transform.up * ThrowUpwardForce;
        //The force and direction is than applied to the projectile
        ProjectileRB.AddForce(ForcetoAdd, ForceMode.Impulse);
       
    }
    private void DestroyClone()
    {
        //The list will hold clones of lanterns until the list reaches a count of 5
        if (LanternClones.Count == 5)
        {
            //For each object in the list a lantern will be deleted from the list and the list will make more space for more lantern
            //This is done to keep the asset count low and able to mantain process speed
            foreach (GameObject LanternC in LanternClones)
            {
                LanternC.SetActive(true);
                GameObject.Destroy(LanternC, 4);
                LanternClones.RemoveAt(4);
            }
        }
        Debug.Log(LanternClones.Count);
    }
}
