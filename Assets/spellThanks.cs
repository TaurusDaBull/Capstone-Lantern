using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class spellThanks : MonoBehaviour
{
    public TMP_Text sayThanks;
    void Start()
    {

        Invoke("ReadText",0.2f);
    }

    void ReadText()
    {
        StartCoroutine("thankYou");
    }
    IEnumerator thankYou()
    {
        yield return new WaitForSecondsRealtime(2);
        string ThankYou = "Thanks for Playing";
        for (int i = 0; i < ThankYou.Length; i++)
        {
        yield return new WaitForSecondsRealtime(0.1f);
            sayThanks.text += ThankYou[i];
        }
        
    }
  
}
