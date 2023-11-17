using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    string strTag;

    private void OnTriggerEnter(Collider other)
    {
        //If the player is in contact of the object
        if (other.gameObject.tag == "Player")
            Debug.Log("Next Level");
        //ScreenManager will move the player to the next designated level
        SceneManager.LoadScene("Lvl 2");
    }
}
