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
    public float lookedAtPhoneTime = 5.0f;

    [Header("Checked Pocket Hint")]
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
        float dist = Vector3.Distance(Phone.transform.position, Player.transform.position);
        if (dist < distanceToPhone && LookedAtPhone == false)
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
