using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypad : MonoBehaviour
{
    public OpenPhone passcodeCorrect;
    public string password = "1111855";
    public string userInput = "";

    public AudioSource click;
    public void buttonClicked(string number) 
    {
        click.Play();
        if (userInput != password) 
        {
            userInput += number;
        }
        

        if (userInput == password)
        {
            passcodeCorrect.ChangeScreen();
        }
        else if (userInput.Length > password.Length)
        {
            userInput = "";
        }
    }
}
