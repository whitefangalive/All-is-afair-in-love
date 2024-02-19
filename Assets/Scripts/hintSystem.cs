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
    public int lookedAtPhoneTime = 5;

    [Header("Checked Pocket Hint")]
    [SerializeField] bool CheckedPocket = false;
    public GameObject Note;
    public int CheckedPocketTime = 10;

    [Header("Checked Calender Hint")]
    [SerializeField] bool CheckedCalender = false;

    [Header("Checked Book Hint")]
    [SerializeField] bool CheckedBook = false;
    // Start is called before the first frame update
    void Start()
    {
        hint = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        minutes = clock.Minutes;
        float dist = Vector3.Distance(Phone.transform.position, Player.transform.position);
        if (dist < distanceToPhone && LookedAtPhone == false)
        {
            LookedAtPhone = true;
        }

        if (LookedAtPhone == false && (minutes % lookedAtPhoneTime == 0 && minutes != 0) && hint.text == "") 
        {
            hint.maxVisibleCharacters = 0;
            hint.text = "Whys their phone going off this late?";
            NotificationSound.Play(0);
        }
        if (minutes % lookedAtPhoneTime + 1 == 0) 
        {
            hint.maxVisibleCharacters = 0;
            hint.text = "";
        }

        if (Note.transform.parent != null) 
        {
            CheckedPocket = true;
        }
        if (CheckedPocket == false && minutes % CheckedPocketTime == 0 && minutes != 0 && hint.text == "")
        {
            hint.maxVisibleCharacters = 0;
            hint.text = "Whats that in their pocket?";
            CheckedPocket = true;
        }
        if (minutes % CheckedPocketTime + 1 == 0)
        {
            hint.maxVisibleCharacters = 0;
            hint.text = "";
        }
    }
}
