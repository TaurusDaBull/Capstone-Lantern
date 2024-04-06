using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainToLVL1 : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadLevel1(string name)
    {
        StartCoroutine(LevelLoad(name));
    }

    IEnumerator LevelLoad(string name)
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Lvl 1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
