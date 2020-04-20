using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody bulletBody;
    float delay = 2.0f; //This implies a delay of 2 seconds.

    
    
    void Start()
    {
        bulletBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Give the cloned object an initial velocity along the current
        // object's Z axis

        bulletBody.velocity = transform.TransformDirection(Vector3.forward * 20);
        Object.Destroy(gameObject, delay);

    }


}
