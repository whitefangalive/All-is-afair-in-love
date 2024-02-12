using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pacer : MonoBehaviour
{
    private Vector3 pos;
    public float waveLength = 1;
    public float amplitute = 1;
    private float startingY;
    // Start is called before the first frame update
    void Start()
    {
        startingY = transform.position.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        pos = transform.position;
        transform.position = new Vector3(pos.x, pos.y + (Mathf.Sin(Time.realtimeSinceStartup * waveLength) * amplitute), pos.z);
    }
}
