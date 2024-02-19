using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floatTillGrab : MonoBehaviour
{
    private Vector3 StartPoint;
    private Rigidbody Rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        StartPoint = transform.position;
        Rigidbody = GetComponent<Rigidbody>();
        Rigidbody.isKinematic = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position != StartPoint) 
        { 
            Rigidbody.isKinematic=false;
        }
    }
}
