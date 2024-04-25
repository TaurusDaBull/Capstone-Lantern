using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowLanternTrajectory : MonoBehaviour
{
    [Header("Lantern")]
    [SerializeField] private GameObject Lantern;
    [SerializeField] private GameObject LanternOnPlayer;
    private Camera MainCamera;
    [Header("Lantern Settings")]
    [SerializeField] private KeyCode ThrowKey = KeyCode.E;
    [SerializeField] private Transform ThrowPosition;
    [SerializeField] private Vector3 ThrowDistance = new Vector3(0, 1, 0);
    [Header("Trajectory Settings")]
    [SerializeField] private LineRenderer TrajectoryLine;
    private bool IsCharging;
    private float ChargeTime = 0f;
    private bool ReadyToThrow;
    [Header("Lantern Force")]
    [SerializeField] private float ThrowForce = 10f;
    [SerializeField] private float MaxForce = 20f;
    private bool onceRespawn;
    private int x = 0;

    private void Start() //Run on start
    {
        //Define Main Camera , Set the ready to throw bool to false and, set the trajectory line to false
        MainCamera = Camera.main;
        ReadyToThrow = false;
        TrajectoryLine.enabled = false;
        onceRespawn = false;
    
    }

    private void Update()
    {
        //If the Lantern has been picked up
        if (LanternOnPlayer.activeInHierarchy == true)
        {
            ReadyToThrow = true; //ready to throw becomes true

            if (Input.GetKeyDown(ThrowKey) && ReadyToThrow == true) //Press and hold the throw key (keyboard key = E)
            {
                StartThrowing(); //Charge throw
            }
            if (IsCharging)
            {
                ChargeThrow();
            }
            if (Input.GetKeyUp(ThrowKey))
            {
                ReleaseThrow();
            }
        }
    
    }
    void StartThrowing()
    {
        IsCharging = true; //Set is charge bool to true to allow ChargeThrow()
        ChargeTime = 0f; //Set charge time to 0
        Lantern.SetActive(true); //Activate Lantern in hierarchy to take properties
        TrajectoryLine.enabled = true; //draw the trajectory line
       
    }
    void ChargeThrow()
    {
        ChargeTime += Time.deltaTime;  //increase charge time by time amount held

        Vector3 LanternVelocity = (MainCamera.transform.forward + ThrowDistance).normalized * Mathf.Min(ChargeTime * ThrowForce, MaxForce);
        ShowTrajectory(ThrowPosition.position + ThrowPosition.forward, LanternVelocity);
    }
    private void ReleaseThrow()
    {
        ThrowLantern(Mathf.Min(ChargeTime * ThrowForce, MaxForce));
        IsCharging = false;
        TrajectoryLine.enabled = false;
        Lantern.SetActive(false);
        ReadyToThrow = false;
        if (onceRespawn == false)
        {
          
            Invoke("lanternThrown", 1);
            onceRespawn = true;
        }
    }
    private void ThrowLantern(float force)
    {
        Vector3 SpawnPosition = ThrowPosition.position + MainCamera.transform.forward;

        GameObject LanternThrow = Instantiate(Lantern, SpawnPosition, MainCamera.transform.rotation);
        LanternThrow.GetComponentInChildren<Light>().color = LanternOnPlayer.GetComponentInChildren<Light>().color;
        LanternThrow.GetComponentInChildren<Light>().intensity = 12;

        Rigidbody rb = LanternThrow.GetComponent<Rigidbody>();

        Vector3 FinalThrowDistance = (MainCamera.transform.forward + ThrowDistance).normalized;
        rb.AddForce(FinalThrowDistance * force, ForceMode.VelocityChange);
    }
    void ShowTrajectory(Vector3 origin, Vector3 speed)
    {
        Vector3[] points = new Vector3[100];
       TrajectoryLine.positionCount = points.Length;
        for (int i = 0; i < points.Length; i++)
        {
            float time = i * 0.1f;
            points[i] = origin + speed * time + 0.5f * Physics.gravity * time * time;
        }
        TrajectoryLine.SetPositions(points);
    }

    void lanternThrown()
    {
        //Lantern throw debugging
        x = + 1;
        Debug.Log(x);
        Debug.Log("Lantern has been thrown");
        //Insert Animation for respawn here
        
    }

}