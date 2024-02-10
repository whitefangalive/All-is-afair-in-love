using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class KeyScript : MonoBehaviour
{
    private TMP_Text m_TextComponent;
    private string number;
    public Keypad keypad;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material.color = Color.white;
        m_TextComponent = GetComponentInChildren<TMP_Text>();

    }

    // Update is called once per frame
    void Update()
    {
        number = m_TextComponent.text;

    }

    public void OnTriggerEnter(Collider other)
    {
        GetComponent<Renderer>().material.color = Color.grey;
        keypad.buttonClicked(number);
    }



    public void OnTriggerExit(Collider other)
    {
        GetComponent<Renderer>().material.color = Color.white;
    }
}
