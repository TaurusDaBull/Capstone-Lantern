using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;


public class DoorOpen : MonoBehaviour
{
    public GameObject Player;
    public GameObject KeyPad;
    public TMP_Text Code;
    public TMP_Text UseKeyPad;
    public Light LockLight;
    [Header("Sound Effects")]
    public AK.Wwise.Event Success;
    public AK.Wwise.Event Fail;
    public AK.Wwise.Event Unlock;
    public AK.Wwise.Event Creak;

    public Animator Door;
    public string Answer;
    public GameObject[] objs;
    

    private void Start()
    {
        LockLight.color = Color.red;
        SetCode();
        //The door animtion will be set to idle in the shut postion at the start of the game
        Door.SetBool("doorSwing", false);
        //The keypad GUI is set to inactive at the start of the game
        KeyPad.GetComponentInChildren<Canvas>().enabled = false;
    }
    public void SetCode()
    {
        //Random function and number is generated between 4 and 8
        System.Random rnd = new System.Random();
        int code = 4;
        //Random number is used to create an integer array
        int[] Set = new int[code];
        //String builder is used to convert the integer array to a string
        StringBuilder sb = new StringBuilder();
        //A for loop is created to iterate through the each array position
        for (int i = 0; i < Set.Length; i++)
        {
            //A random number is generated from 0 - 9
            int x = rnd.Next(0, 9);
            //the number is set at postion 0
            Set[i] = x;
            //the String builed appends the numbers
            sb.Append(Set[i]);
        }   
        //the completed append string is than set to the Answer
        Answer = sb.ToString();
        Debug.Log("The passcode is: " + Answer);
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
       
       
        if (Door == true)
        {
            LockLight.color = Color.green;
            AkSoundEngine.PostEvent("doorCreak", gameObject);

        }
        return;      
        
    }
    public void Number(int number)
    {

       Code.text += number.ToString();
        if (Code.text.Length == 8 )
        {
            OnDisable();

        }

    }

    public void Clear()
    {
        Code.text = string.Empty;
        Code.faceColor = Color.black;
        Code.outlineColor = Color.black;
        OnEnable();
    }

    private void StopPlayer()
    {
        Player.gameObject.GetComponent<FirstPersonController>().enabled = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void ResumePlayer()
    {
        Player.gameObject.GetComponent<FirstPersonController>().enabled = true;
        Cursor.visible = false;
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
            //Open Door
            //Display Correct
            Code.text = "Correct";
            Code.faceColor = Color.green;
            Code.outlineColor = Color.green;
            AkSoundEngine.PostEvent("keypadSuccess", gameObject);

            //Resume Player after 1 second
            AkSoundEngine.PostEvent("doorUnlock", gameObject);
            Invoke("OpenDoor", 2);
            Invoke("ResumePlayer", 2);
            Door.SetBool("doorSwing", true);
        }  
        else
        {
            Clear();
            OnDisable();
            Code.text = "Incorrect";
            Code.faceColor = Color.red;
            Code.outlineColor = Color.red;
            AkSoundEngine.PostEvent("keypadFail", gameObject);

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
