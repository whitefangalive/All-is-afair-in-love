using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPhone : MonoBehaviour
{
    public GameObject screen1;
    public GameObject screen2;
    public AudioSource click;

    private bool opening = false;
    public void ChangeScreen()
    {
        if (screen1.activeInHierarchy == true)
        {
            screen1.SetActive(false);
            click.Play(0);

            opening = true;
        }
    }

    public void FixedUpdate()
    {
        if (opening == true)
        {
            screen2.transform.position = Vector3.Lerp(screen2.transform.position, new Vector3(screen2.transform.position.x, 
                screen2.transform.position.y + 0.75f, screen2.transform.position.z), Time.deltaTime * 1);
        }
    }
}
