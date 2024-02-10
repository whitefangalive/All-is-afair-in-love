using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Clock : MonoBehaviour
{
    private TMP_Text m_TextComponent;
    public float Seconds = 0;
    public int Minutes = 0;
    public float RealSecondsInOneMinute = 6;
    // Start is called before the first frame update
    void Start()
    {
        m_TextComponent = GetComponent<TMP_Text>();
    }

    // FixedUpdate is called 50 timer per second;
    void FixedUpdate()
    {
        Seconds += 0.02f;
        Minutes = (int)(Seconds / RealSecondsInOneMinute);
        m_TextComponent.text = "11:" + Minutes.ToString("00");
    }
}
