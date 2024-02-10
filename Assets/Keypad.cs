using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypad : MonoBehaviour
{
    public void buttonClicked(int number) 
    {
        Debug.Log($"ClickedFromKeypad {number}");
    }
}
