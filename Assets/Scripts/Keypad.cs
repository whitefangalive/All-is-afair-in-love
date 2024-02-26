using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

using System.Linq;

public class Keypad : MonoBehaviour
{
    public OpenPhone passcodeCorrect;
    public string password = "77772655";
    public string[] passwords = new string[] { };
    public string userInput = "";

    public AudioSource click;
    public void buttonClicked(string number) 
    {
        click.Play();
        if (!passwords.Contains(userInput) && (number != ">" && number != "X")) 
        {
            userInput += number;
        }


        if (passwords.Contains(userInput) && number == ">")
        {
            passcodeCorrect.ChangeScreen();
            TMP_Text loseDialogue = GameObject.Find("LoseDialogueText").GetComponent<TMP_Text>();
            loseDialogue.maxVisibleCharacters = 0;
            loseDialogue.text = "You Win.";
        } else if (!passwords.Contains(userInput) && number == ">") 
        {
            userInput = "";
        }
        if (number == "X" && userInput.Length > 0)
        {
            userInput = userInput.Remove(userInput.Length - 1);
        }
    }
}
