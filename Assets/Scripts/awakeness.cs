using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class awakeness : MonoBehaviour
{
    public int awake = 3;
    public GameObject Z;
    public float maxIFrames = 60;
    [SerializeField] private float iFrames = 120;
    public AudioSource snore;

    public GameObject tryAgainCube;

    private void Start()
    {
        tryAgainCube.SetActive(false);
        for (int i = 1; i < awake; i++)
        {
            GameObject zObject = Instantiate(Z, this.transform);
            zObject.name = "z" + i.ToString();
            zObject.GetComponent<RectTransform>().localPosition += new Vector3(0.2f * i, 0.2f * i, 0);
        }

        snore = GetComponent<AudioSource>();
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
                //Destroy(currentZ);
                currentZ.GetComponent<TMP_Text>().color = Color.black;
                snore.Play(0);
            }
        }
        if (awake <= 0)
        {
           TMP_Text loseDialogue = GameObject.Find("LoseDialogueText").GetComponent<TMP_Text>();
            loseDialogue.maxVisibleCharacters = 0;
            loseDialogue.text = "You Lose.";
            tryAgainCube.SetActive(true);

        }
    }
}
