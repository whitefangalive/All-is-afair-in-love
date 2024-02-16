using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pocketCollision : MonoBehaviour
{
    public awakeness scoreManager;

    private void OnTriggerEnter(Collider other)
    {
        scoreManager.hit();
    }

}
