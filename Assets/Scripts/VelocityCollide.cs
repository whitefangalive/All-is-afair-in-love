using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(Rigidbody))]
public class VelocityCollide : MonoBehaviour
{
    private Rigidbody rb;
    public float audioVelocity = 4.0f;

    private AudioSource collisionSound;
    private awakeness scoreManager;
    private Vector3 previousVelocity;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        scoreManager = GameObject.FindGameObjectWithTag("scoreManager").GetComponent<awakeness>();
        collisionSound = GetComponent<AudioSource>();
    }
    private void Update()
    {
        if (Time.frameCount % 5 == 0)
        {
            previousVelocity = rb.velocity;
        }
    }
    void OnCollisionEnter(Collision collision)
    {

        Debug.Log(previousVelocity.magnitude.ToString());
        if (previousVelocity.magnitude > audioVelocity) 
        { 
            collisionSound.Play(0);
            scoreManager.hit();
        }
        if (collision.rigidbody != null)
        {
            if (collision.rigidbody.velocity.magnitude > audioVelocity)
            {
                collisionSound.Play(0);
                scoreManager.hit();
            }
        }
        
    }
}
