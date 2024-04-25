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
        //At start wait .2 seconds before executing ReadText()
        Invoke("ReadText",0.2f);
    }

    void ReadText()
    {
        StartCoroutine("thankYou");
    }
    IEnumerator thankYou()
    {
        //Spell one letter at a time "Thanks for Playing" waiting 0.1 before each letter
        yield return new WaitForSecondsRealtime(2);
        string ThankYou = "Thanks for Playing"; 
        for (int i = 0; i < ThankYou.Length; i++)
        {
        yield return new WaitForSecondsRealtime(0.1f);
            sayThanks.text += ThankYou[i];
        }
        
    }
  
}
