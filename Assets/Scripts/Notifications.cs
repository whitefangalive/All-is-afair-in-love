using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notifications : MonoBehaviour
{
    public Clock clock;
    private int minutes;

    public GameObject Text1;
    public GameObject Text2;

    public int Text1Time = 1;
    public int Text2Time = 2;

    public AudioSource NotificationSound;
    // Start is called before the first frame update
    void Start()
    {
        

        Text1.SetActive(false);
        Text2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        minutes = clock.Minutes;
        if (minutes == 1 && Text1.activeInHierarchy == false) 
        {
            Text1.SetActive(true);
            NotificationSound.Play(0);
        }
        if (minutes == 2 && Text2.activeInHierarchy == false)
        {
            Text2.SetActive(true);
            NotificationSound.Play(0);
        }
    }
}
