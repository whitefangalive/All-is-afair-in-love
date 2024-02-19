using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class hintSystem : MonoBehaviour
{
    public Clock clock;
    private int minutes;

    [Header("Phone Hint")]
    public GameObject Phone;
    public GameObject Player;
    public float distanceToPhone = 5f;

    private TMP_Text hint;
    public AudioSource NotificationSound;

    [SerializeField] bool LookedAtPhone = false;
    public int CheckedPhoneFrequency = 4;
    public int CheckedPhoneStartTime = 5;

    [Header("Checked Pocket Hint")]
    [SerializeField] bool CheckedPocket = false;
    public GameObject Note;
    public int CheckedNoteFrequency = 4;
    public int CheckedNoteStartTime = 5;

    [Header("Checked Calender Hint")]
    [SerializeField] bool CheckedCalender = false;
    public GameObject Calender;
    public int CheckedCalenderFrequency = 4;
    public int CheckedCalenderStartTime = 5;
    public float distanceToCalender = 1.5f;

    [Header("Checked Book Hint")]
    [SerializeField] bool CheckedBook = false;
    public GameObject Book;
    public int CheckedBookFrequency = 4;
    public int CheckedBookStartTime = 5;
    // Start is called before the first frame update
    void Start()
    {
        hint = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        minutes = clock.Minutes;
        PhoneHint(CheckedPhoneFrequency, CheckedPhoneStartTime);
        if (LookedAtPhone == true) 
        {
            NoteHint(CheckedNoteFrequency, CheckedNoteStartTime);
            if (CheckedPocket == true) 
            {
                CalenderHint(CheckedCalenderFrequency, CheckedCalenderStartTime);
                if (CheckedCalender == true)
                {
                    bookHint(CheckedBookFrequency, CheckedBookStartTime);
                }
            }
        } 
    }

    private void PhoneHint(int frequency, int startTime) 
    {
        float dist = Vector3.Distance(Phone.transform.position, Player.transform.position);
        if (dist < distanceToPhone && LookedAtPhone == false)
        {
            LookedAtPhone = true;
        }

        if (LookedAtPhone == false && ((minutes % frequency) == 0 && minutes >= startTime) && hint.text == "")
        {
            hint.maxVisibleCharacters = 0;
            hint.text = "Whys their phone going off this late?";
            NotificationSound.Play(0);
        }
        if (minutes % (frequency + 1) == 0)
        {
            hint.maxVisibleCharacters = 0;
            hint.text = "";
        }
    }
    private void NoteHint(int frequency, int startTime) 
    {
        if (Note.transform.parent != null)
        {
            CheckedPocket = true;
        }
        if (CheckedPocket == false && minutes % frequency == 0 && minutes >= startTime && hint.text == "")
        {
            hint.maxVisibleCharacters = 0;
            hint.text = "Whats that in their pocket?";
        }
        if (minutes % (frequency + 1) == 0)
        {
            hint.maxVisibleCharacters = 0;
            hint.text = "";
        }
    }
    private void CalenderHint(int frequency, int startTime)
    {
        float distCalender = Vector3.Distance(Calender.transform.position, Player.transform.position);
        if (distCalender < distanceToCalender && CheckedCalender == false)
        {
            CheckedCalender = true;
        }

        if (CheckedCalender == false && (minutes % frequency == 0 && minutes >= startTime) && hint.text == "")
        {
            hint.maxVisibleCharacters = 0;
            hint.text = "I think their birthday is on the calender somewhere . . .";
        }
        if (minutes % (frequency + 1) == 0)
        {
            hint.maxVisibleCharacters = 0;
            hint.text = "";
        }
    }
    private void bookHint(int frequency, int startTime) 
    {
        if (Book.transform.parent != null)
        {
            CheckedBook = true;
        }
        if (CheckedBook == false && minutes % frequency == 0 && minutes >= startTime && hint.text == "")
        {
            hint.maxVisibleCharacters = 0;
            hint.text = "Maybe I can find a clue in one of their books.";
        }
        if (minutes % (frequency + 1) == 0)
        {
            hint.maxVisibleCharacters = 0;
            hint.text = "";
        }
    }
}
