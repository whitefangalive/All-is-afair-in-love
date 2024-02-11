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
        if (userInput != password && (number != ">" && number != "X")) 
        {
            userInput += number;
        }


        if (userInput == password && number == ">")
        {
            passcodeCorrect.ChangeScreen();
        } else if (userInput != password && number == ">") 
        {
            userInput = "";
        }
        if (number == "X" && userInput.Length > 0)
        {
            userInput = userInput.Remove(userInput.Length - 1);
        }
        Debug.Log(number);
        Debug.Log(userInput);
    }
}
