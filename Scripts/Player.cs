using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;
    //public Rigidbody rb;
    //Vector3 movement = Vector3.zero;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Using a Character Controller, unfortunately is disorienting in a top-down setting.
        //CharacterController controller = GetComponent<CharacterController>();

        //PlayerMovement 

        //movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        //movement = transform.TransformDirection(movement);
       // movement *= moveSpeed; //set player speed
        //controller.Move(movement * Time.deltaTime);

         
 
       //Grab specific keys to move
         Vector3 pos = transform.position;
 
         if (Input.GetKey (KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {
             pos.z += moveSpeed * Time.deltaTime;
         }
         if (Input.GetKey (KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) {
             pos.z -= moveSpeed * Time.deltaTime;
         }
         if (Input.GetKey (KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
             pos.x += moveSpeed * Time.deltaTime;
         }
         if (Input.GetKey (KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
             pos.x -= moveSpeed * Time.deltaTime;
         }
             
 
         transform.position = pos;
     
    }

        

}
