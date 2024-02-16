using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class awakeness : MonoBehaviour
{
    public int awake = 3;
    public GameObject Z;
    public float maxIFrames = 60;
    [SerializeField] private float iFrames = 0;

    private void Start()
    {
        for (int i = 1; i < awake; i++)
        {
            GameObject zObject = Instantiate(Z, this.transform);
            zObject.name = "z" + i.ToString();
            zObject.GetComponent<RectTransform>().localPosition += new Vector3(0.2f * i, 0.2f * i, 0);
        }
    }
    private void FixedUpdate()
    {
        if (iFrames > 0) 
        {
            iFrames--;
        }
    }
    public void hit()
    {
        if (iFrames == 0)
        {
            iFrames = maxIFrames;
            awake--;
            GameObject currentZ = GameObject.Find("z" + awake.ToString());
            if (currentZ != null)
            {
                Destroy(currentZ);
                Debug.Log("Was able to find " + currentZ.name.ToString() + " and tried to destroy it.");
            }
            else
            {
                Debug.Log("Unable to find " + currentZ.name.ToString());
            }
        }
    }
}
