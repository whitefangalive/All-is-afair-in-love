using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class hintSystem : MonoBehaviour
{
    public Clock clock;
    private int minutes;

    public Keypad Keypad;

    private TMP_Text hint;
    public AudioSource NotificationSound;

    [Header("Achievements")]
    [SerializeField] bool LookedAtPhone = false;
    public float lookedAtPhoneTime = 5.0f;
    [SerializeField] bool CheckedPocket = false;
    // Start is called before the first frame update
    void Start()
    {
        hint = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        minutes = clock.Minutes;
        if (Keypad.userInput.Length > 0 && LookedAtPhone == false)
        {
            LookedAtPhone = true;
        }

        if (LookedAtPhone == false && minutes == lookedAtPhoneTime) 
        {
            hint.maxVisibleCharacters = 0;
            hint.text = "Whys their phone going off this late?";
            NotificationSound.Play(0);
            LookedAtPhone = true;
        }
        if (minutes == lookedAtPhoneTime + 1) 
        {
            hint.maxVisibleCharacters = 0;
            hint.text = "";
        }
    }
}
