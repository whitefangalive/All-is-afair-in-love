using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class updatePassCode : MonoBehaviour
{
    private TMP_Text m_TextComponent;
    public Keypad keypad;
    private string input;
    // Start is called before the first frame update
    void Start()
    {
        
        m_TextComponent = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        input = keypad.userInput;
        Debug.Log(input);
        if (input.Length > 0) 
        {
            m_TextComponent.text = input;
        }
    }
}
