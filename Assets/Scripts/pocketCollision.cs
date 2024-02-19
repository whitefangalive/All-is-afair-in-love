using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pocketCollision : MonoBehaviour
{
    public awakeness scoreManager;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag != "sleepingPerson") 
        {
            scoreManager.hit();
        }
    }
}
