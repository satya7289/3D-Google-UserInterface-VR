using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KeyboardText : MonoBehaviour
{
    public InputField myText;
   // public TMP_InputField MyInput;
    
    string word = null;
    string alpha;
    int wordIndex = 0;

    public void alphabetFunction(string alphabet)
    {
        wordIndex++;
        word = word + alphabet;
        myText.text = word;
      //  MyInput.text = word;
       // MyInput.text = "dshbcdhbcu";
    }

    public void deleteAlphabet()
    {
        word = null;
        myText.text = word;
    }
    
}
