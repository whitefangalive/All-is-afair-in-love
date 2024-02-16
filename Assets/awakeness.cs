using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class awakeness : MonoBehaviour
{
    public int awake = 3;
    public GameObject Z;
    private void Start()
    {
        for (int i = 1; i < awake; i++)
        {
            GameObject zObject = Instantiate(Z);
            zObject.name = awake.ToString();
            zObject.GetComponent<RectTransform>().localPosition += new Vector3(0.2f * i, 0.2f * i, 0);
        }
    }
    public void hit()
    {
        awake--;
        GameObject currentZ = GameObject.Find(awake.ToString());
        if (currentZ != null) 
        {
            Destroy(currentZ);
        }
    }
}
