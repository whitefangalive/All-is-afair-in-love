using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixDupedObjects : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.Find("DontDestroyOnLoad") != null) 
        {
            Debug.Log("FoundDDOL");
        }
    }
}
