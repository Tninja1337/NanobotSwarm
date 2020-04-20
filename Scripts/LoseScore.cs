using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseScore : MonoBehaviour
{
    public GameUI gameUI;
    //Track Player Score
    int nanoScore;

    // Start is called before the first frame update
    void Start()
    {
        nanoScore = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Nanobot")
        {
            nanoScore++;
            gameUI.SetNanoScore(nanoScore);
        }
    }
}
