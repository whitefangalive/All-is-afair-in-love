using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using UnityEngine.SceneManagement;

public class TryAgain : MonoBehaviour
{
    public void clicking()
    {
        SteamVR_LoadLevel.Begin(SceneManager.GetActiveScene().name);
    }
}
