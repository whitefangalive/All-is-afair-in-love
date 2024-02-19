using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoCollideTillGrab : MonoBehaviour
{
    private Vector3 StartPoint;
    private BoxCollider boxCollider;
    // Start is called before the first frame update
    void Start()
    {
        StartPoint = transform.position;
        boxCollider = GetComponent<BoxCollider>();
        boxCollider.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position != StartPoint) 
        {
            boxCollider.enabled = false;
        }
    }
}
