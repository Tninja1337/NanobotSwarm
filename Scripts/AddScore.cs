using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddScore : MonoBehaviour
{

    public GameUI gameUI;
    public CrawlerAgent crawlerScript;
    //Track Player Score
    

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Bullet")
        {
            
            gameUI.SetPlayerScore();
            crawlerScript.gotShot();
        }
    }

}
