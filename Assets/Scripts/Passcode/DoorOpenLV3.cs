using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.UI;


public class DoorOpenLV3 : MonoBehaviour
{
    public GameObject Player;
    public GameObject KeyPad;
    public AudioSource Correct;
    public TMP_Text Code;
    public TMP_Text UseKeyPad;

    public Animator Door;
    public string Answer;
    public GameObject[] objs;

    [Header("Codes for Panels")]
    public string PartA;
    public string PartB;
    public string PartC;

    [Header("Door Objects")]
    public GameObject[] cubes;
    public TMP_Text[] arrows;

    private void Start()
    {
       
        SetCode();
        //The door animtion will be set to idle in the shut postion at the start of the game
        Door.SetBool("Idle", true);
        //The keypad GUI is set to inactive at the start of the game
        KeyPad.GetComponentInChildren<Canvas>().enabled = false;
    }
    public void SetCode()
    {
        //Random function and number is generated between 4 and 8
        System.Random rnd = new System.Random();
        int code = 6;
        //Random number is used to create an integer array
        int[] Set = new int[code];
        //String builder is used to convert the integer array to a string
        StringBuilder sb = new StringBuilder();
        //A for loop is created to iterate through the each array position
        for (int i = 0; i < Set.Length; i++)
        {
            //A random number is generated from 0 - 9
            int x = rnd.Next(0, 6);
            //the number is set at postion 0
            Set[i] = x;
            //the String builed appends the numbers
            sb.Append(Set[i]);
        }   
        //the completed append string is than set to the Answer
        Answer = sb.ToString();

        PartA = Answer.Substring(0, 2);
        PartB = Answer.Substring(2, 2);
        PartC = Answer.Substring(4, 2);

        Debug.Log("The passcode is: " + Answer);
        Debug.Log("Part 1 is: " + PartA + " Part 2 is: " +  PartB + " Part 3 is: " + PartC);
    }
    // Update is called once per frame
     private void OnTriggerStay(Collider collison)
    {
        //If the player comes into contact with the key pad object
        if (collison.gameObject.tag == "Reach")
        {
            //text is displayed to and instructs the user to right click to use
            UseKeyPad.text = "Right Click to Use";
            
            if (Input.GetButton("Fire2"))
            {
                //the user right clicks and runs the KeyPad on Function
                Debug.Log("EnterKey");
                KeyPadOn();
            }
            
        
        }
     
    }
    private void OnTriggerExit(Collider collison)
    {
        UseKeyPad.text = " ";
    }
    private void OpenDoor()
    {
        Door.SetBool("Open", true);
        Door.SetBool("Idle", false);
        if (Door == true)
        {
        Correct.Play();
            GameObject.Destroy(cubes[0]);
            GameObject.Destroy(cubes[1]);
            GameObject.Destroy(cubes[2]);
            GameObject.Destroy(arrows[0]);
            GameObject.Destroy(arrows[1]);
        }
        return;      
        
    }
    public void Number(int number)
    {

       Code.text += number.ToString();
        if (Code.text.Length == 9 )
        {
            OnDisable();

        }

    }
    public void Clear()
    {
        Code.text = string.Empty;
      OnEnable();
    }

    private void StopPlayer()
    {
        Player.GetComponent<PlayerMotor>().speed = 0;
        Player.GetComponent<PlayerLook>().xSensitivity = 0;
        Player.GetComponent<PlayerLook>().ySensitivity = 0;
        Cursor.lockState = CursorLockMode.None;
    }
    public void ResumePlayer()
    {
        Player.GetComponent<PlayerMotor>().speed = 50;
        Player.GetComponent<PlayerLook>().xSensitivity = 30;
        Player.GetComponent<PlayerLook>().ySensitivity = 30;
        Cursor.lockState = CursorLockMode.Locked;
        Clear();
        KeyPadOff();
    }

    private void KeyPadOn()
    {
        KeyPad.GetComponentInChildren<Canvas>().enabled = true;
        StopPlayer();
  
    }


    private void KeyPadOff()
    {
        KeyPad.GetComponentInChildren<Canvas>().enabled = false;
        
    }

    public void Enter(string guess)
    {
        guess = Code.text;
        if (guess == Answer)
        {
            ResumePlayer();
            OpenDoor();
        }  
        else
        {
            Clear();
            OnDisable();
            Code.text = "Incorrect";
        }
    }
    public void OnDisable()
    {
        objs = GameObject.FindGameObjectsWithTag("KeyPad");
        foreach (GameObject button in objs)
        {
            button.GetComponent<Button>().interactable = false;
        }
    }
    public void OnEnable()
    {
        objs = GameObject.FindGameObjectsWithTag("KeyPad");
        foreach (GameObject button in objs)
        {
            button.GetComponent<Button>().interactable = true;
        }
    }

}
