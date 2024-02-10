using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class KeyScript : MonoBehaviour
{
    private TMP_Text m_TextComponent;
    private string number;
    // Start is called before the first frame update
    void Start()
    {
        m_TextComponent = GetComponentInChildren<TMP_Text>();

    }

    // Update is called once per frame
    void Update()
    {
        number = m_TextComponent.text;
    }

    public UnityEvent KeypadClicked;
    public void OnClick() 
    {
        Debug.Log("Clicked " + number);
        KeypadClicked.Invoke();
    }
}
