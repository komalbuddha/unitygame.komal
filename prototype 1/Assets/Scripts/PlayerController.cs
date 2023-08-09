using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 15.0f;
    public float turnSpeed;
    public float horizontalInput;
    public float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
     //let's go
     transform.Translate(Vector3.forward*Time.deltaTime*speed*verticalInput);   
     transform.Rotate(Vector3.up,Time.deltaTime*turnSpeed*horizontalInput);

         }
}
